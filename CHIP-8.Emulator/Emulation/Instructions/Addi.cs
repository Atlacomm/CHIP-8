using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Addi(int register, byte value)
        {
            Console.WriteLine($"addi V{register.ToString("X")}, {value}");

            V[register] += value;

            pc += 2;
        }
    }
}
