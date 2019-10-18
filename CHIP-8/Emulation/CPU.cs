using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    class CPU
    {
        // TODO: Implement user definable clock speed
        public const int CLOCKSPEED = 500;

        Emulator emulator;

        byte[] V = null;
        ushort I = 0;

        ushort[] stack = null;
        int sp = 0;

        byte delayTimer = 0;
        byte soundTimer = 0;

        ushort pc = 512;

        public CPU(Emulator emulator)
        {
            this.emulator = emulator;

            V = new byte[16];
            stack = new ushort[32];
        }

        public void UpdateTimers()
        {
            if (delayTimer > 0) delayTimer--;
            if (soundTimer > 0) soundTimer--;

            // TODO: Make a beep when sound timer is not zero
        }

        public void EmulateCycle()
        {
            ushort opcode = (ushort)((emulator.memory[pc] << 8) | emulator.memory[pc + 1]);
            bool foundCode = true;

            switch (opcode & 0xF000)
            {
                case 0x2000: // 2NNN - Call subroutine at NNN
                    ushort adress = (ushort)(opcode & 0x0FFF);
                    Call(adress);
                    break;
                case 0x6000: // 6XNN - Sets VX to NN
                    int reg = (opcode & 0x0F00) >> 8;
                    byte val = (byte)(opcode & 0x00FF);
                    Mov(reg, val);
                    pc += 2;
                    break;
                case 0xA000: // ANNN - Sets I to the address NNN
                    IMov((ushort)(opcode & 0x0FFF));
                    pc += 2;
                    break;
                case 0xD000: // DXYN - Draw sprite at (VX, VY); Size 8xN; Data starts at I. VF=1 if pixels are flipped to off else VF=0
                    int regX = (opcode & 0x0F00) >> 8;
                    int regY = (opcode & 0x00F0) >> 4;
                    byte height = (byte)(opcode & 0x000F);
                    Sprite(regX, regY, height);
                    pc += 2;
                    break;
                default:
                    foundCode = false;
                    break;
            }

            if (!foundCode)
            {
                Console.WriteLine("Unknown opcode: 0x" + opcode.ToString("X4"));
                Console.ReadKey();
            }
        }

        public void Call(ushort adress)
        {
            Console.WriteLine($"call {adress}");

            stack[sp] = (ushort)(pc + 2);
            sp++;
            pc = adress;
        }

        public void Mov(int register, byte value)
        {
            Console.WriteLine($"mov V{register.ToString("X")}, {value}");

            V[register] = value;
        }

        public void IMov(ushort value)
        {
            Console.WriteLine($"imov {value}");

            I = value;
        }

        public void Sprite(int registerX, int registerY, byte height)
        {
            Console.WriteLine($"sprite V{registerX.ToString("X")}, V{registerY.ToString("X")}, {height}");

            byte x = V[registerX];
            byte y = V[registerY];

            byte[] spriteData = new byte[height];
            for (int i = 0; i < spriteData.Length; i++) spriteData[i] = emulator.memory[I + i];

            bool flippedToOff = false;

            for (int yy = 0; yy < spriteData.Length; yy++)
            {
                string currentRow = Convert.ToString(spriteData[yy], 2);
                for (int xx = 0; xx < currentRow.Length; xx++)
                {
                    int newX = x + xx;
                    int newY = y + yy;

                    if (newX < SCREENWIDTH && newY < SCREENHEIGHT && newX >= 0 && newY >= 0 && currentRow[xx] == '1')
                    {
                        int index = newX + newY * SCREENWIDTH;

                        emulator.frameBuffer[index] = !emulator.frameBuffer[index];

                        bool newVal = emulator.frameBuffer[index];
                        if (newVal == false) flippedToOff = true;
                    }
                }
            }

            if (flippedToOff) V[0xF] = 1;
            else V[0xF] = 0;
        }
    }
}
