using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Add(int register, byte value)
        {
            Console.WriteLine($"add V{register.ToString("X")}, {value}");

            int newVal = V[register] + value;
            while (newVal > byte.MaxValue) newVal -= byte.MaxValue;

            V[register] = (byte)newVal;

            pc += 2;
        }
    }
}
