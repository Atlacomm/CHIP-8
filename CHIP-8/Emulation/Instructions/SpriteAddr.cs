using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void SpriteAddr(int register)
        {
            Console.WriteLine($"spriteaddr 0x{register.ToString("X")}");

            byte character = V[register];

            I = emulator.fontOffsets[character];

            pc += 2;
        }
    }
}
