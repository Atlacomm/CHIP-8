using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sne(int register, byte value)
        {
            Console.WriteLine($"sne V{register.ToString("X")}, {value}");

            if (V[register] != value) pc += 2;

            pc += 2;
        }
    }
}
