using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    class Emulator
    {
        // Font
        static readonly char[] CHARS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        const ushort FONTOFFSET = 0;
        public ushort[] fontOffsets;

        // Update target in Hertz
        const int UPDATETARGET = 60;

        // Size of the machine memory
        const ushort MEMORYSIZE = 4096;

        // Offset at which the rom should be loaded into memory
        const ushort ROMOFFSET = 512;

        // Thread where the emulation happens
        Thread emulationThread = null;

        public byte[] memory = null;
        public Display display = null;
        CPU cpu = null;

        // Should the emulation end?
        bool emulationShouldEnd = false;

        public bool[] frameBuffer = null;

        public Emulator(byte[] romData)
        {
            // Initialize memory
            memory = new byte[MEMORYSIZE];
            for (int i = 0; i < memory.Length; i++) memory[i] = 0;

            // Initialize font
            fontOffsets = new ushort[CHARS.Length];
            LoadFontset("fontset.txt");

            // Load rom into memory
            for (int i = 0; i < romData.Length; i++)
            {
                if (i + ROMOFFSET>= memory.Length)
                {
                    // TODO: Implement warning for when the rom does not fit into memory
                    break; // Break to avoid an IndexOutOfRangeException
                }

                // Load rom at offset in memory
                memory[i + ROMOFFSET] = romData[i];
            }

            MemDump("memdump.bin", false);

            // Create the CPU
            cpu = new CPU(this);

            // Initialize the frame buffer
            frameBuffer = new bool[SCREENWIDTH * SCREENHEIGHT];

            // Perform emulation tasks
            emulationThread = new Thread(() =>
            {
                // Setup the emulationTimer
                Stopwatch emulationTimer = new Stopwatch();
                emulationTimer.Start();

                Display display = new Display();

                // Run the emulation until we want to stop it
                while (!emulationShouldEnd)
                {
                    // Update UPDATETARGET times per second
                    if (emulationTimer.Elapsed.TotalMilliseconds >= 1000 / UPDATETARGET)
                    {
                        // Update timers
                        cpu.UpdateTimers();

                        // Restart the timer
                        emulationTimer.Restart();

                        // Run CPU Cycles until the target cycle count has been reached
                        int targetCycles = CPU.CLOCKSPEED / UPDATETARGET;
                        int cycles = 0;

                        while (cycles < targetCycles && !emulationShouldEnd)
                        {
                            cpu.EmulateCycle();
                            cycles++;
                            display.RenderBuffer(frameBuffer);
                        }
                    }
                }

                display.Dispose();
                cpu.Dispose();
            });

            // Start the emulation
            emulationThread.Start();
        }

        public void LoadFontset(string path)
        {
            // If the specified file does not exist return
            if (!File.Exists(path))
            {
                MessageBox.Show("The fontset configuration file could not be found. This may result in undefined behaviour!", "Fontset configuration missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] file = File.ReadAllLines(path);

            ushort memoryOffset = FONTOFFSET;

            for (int i = 0; i < CHARS.Length; i++)
            {
                int offset = 0;
                for (int j = 0; j < file.Length; j++)
                {
                    if (file[j] == CHARS[i].ToString())
                    {
                        offset = j + 1;
                        break;
                    }
                }

                fontOffsets[i] = memoryOffset;

                // If the offset is outside of the file break
                if (offset >= file.Length) break;

                // Load font into memory
                for (int j = offset; j < offset + 5; j++, memoryOffset++)
                {
                    string currentLine = file[j];

                    string b = "";

                    foreach (char c in currentLine)
                    {
                        if (c == ' ') b += "0";
                        else b += "1";
                    }

                    while (b.Length < 8) b += "0";

                    // If number is not a valid binary number return
                    foreach (char c in b) if (c != '1' && c != '0') return;

                    memory[memoryOffset] = Convert.ToByte(b, 2);
                }
            }
        }

        public void MemDump(string path, bool plainText = true)
        {
            if (File.Exists(path)) File.Delete(path);

            if (!plainText)
            {
                File.WriteAllBytes(path, memory);
                return;
            }

            List<string> memDump = new List<string>();

            memDump.Add("Offset(h) 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F");
            memDump.Add("");
            for (int i = 0; i < memory.Length; i += 16)
            {
                string line = i.ToString("X8") + " ";

                for (int j = 0; j < 16; j++)
                {
                    if (i % 2 == 0) line += " ";
                    line += memory[i + j].ToString("X2");
                }

                memDump.Add(line);
            }

            File.WriteAllLines(path, memDump.ToArray());
        }

        // Make the emulation thread exit and wait for it
        public void WaitForEnd()
        {
            // Tell the emulation thread it should end
            emulationShouldEnd = true;

            // Wait until the emulation thread has ended
            while (emulationThread.IsAlive) ;

            return;
        }

        // Kill the emulation thread (not recommended)
        public void Kill()
        {
            emulationThread.Abort();
        }
    }
}
