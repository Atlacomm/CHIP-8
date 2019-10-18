using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace CHIP8.Emulation
{
    class Emulator
    {
        const ushort memorySize = 4096;
        const ushort romOffset = 512;

        Thread emulationThread = null;

        byte[] memory = null;
        CPU cpu = null;

        bool ended = false;

        public Emulator(byte[] romData)
        {
            // Initialize memory
            memory = new byte[memorySize];
            for (int i = 0; i < memory.Length; i++) memory[i] = 0;

            // Load rom into memory
            for (int i = 0; i < romData.Length; i++)
            {
                if (i >= memory.Length)
                {
                    // TODO: Implement warning for when the rom does not fit into memory
                    break; // Break to avoid an IndexOutOfBoundsException
                }

                // Load rom at offset in memory
                memory[i + romOffset] = romData[i];
            }

            // Create the CPU
            cpu = new CPU(memory);

            // Perform emulation tasks
            emulationThread = new Thread(() =>
            {
                Stopwatch emulationTimer = new Stopwatch();
                emulationTimer.Start();

                while (!ended)
                {
                    // TODO: Implement emulation
                }
            });
            emulationThread.Start();
        }

        public void WaitForEnd()
        {
            ended = true;

            while (emulationThread.IsAlive) ;

            return;
        }
    }
}
