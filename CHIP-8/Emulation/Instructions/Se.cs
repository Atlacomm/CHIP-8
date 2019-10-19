using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Se(int register, byte value)
        {
            Console.WriteLine($"se V{register.ToString("X")}, {value}");

            if (V[register] == value) pc += 2;

            pc += 2;
        }
    }
}
