using System;

namespace CHIP8.Emulation
{
    partial class CPU
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

            // Decode a given opcode and call it's corresponding function
            switch (opcode & 0xF000)
            {
                case 0x0000:
                    switch (opcode)
                    {
                        case 0x00EE: // 00EE - Return from a subroutine
                            Ret();
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
                    break;
                case 0x2000: // 2NNN - Call subroutine at NNN
                    Call((ushort)(opcode & 0x0FFF));
                    break;
                case 0x6000: // 6XNN - Set VX to NN
                    Mov((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0x7000: // 7XNN - Add NN to VX
                    Add((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0xA000: // ANNN - Set I to the address NNN
                    IMov((ushort)(opcode & 0x0FFF));
                    break;
                case 0xD000: // DXYN - Draw sprite at (VX, VY); Size 8xN; Data starts at I; If pixels are flipped to off VF=1 else VF=0
                    Sprite((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4, (byte)(opcode & 0x000F));
                    break;
                case 0xF000:
                    switch (opcode & 0x00FF)
                    {
                        case 0x0007: // FX07 - Set VX to delay timer
                            GetDelayTimer((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0029: // FX29 - Set I to the location of the sprite for the character in VX.
                            SpriteAddr((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0033: // FX33 - Store binary-coded decimal representation of VX at I, I + 1 and I + 3
                            Bcd((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0065: // FX65 - Fill V0 to VX (including VX) with memory starting at I. Offset increases by 1 for each value; I unmodified.
                            Fill((opcode & 0x0F00) >> 8);
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
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
    }
}
