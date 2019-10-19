using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Gdt(int register)
        {
            Console.WriteLine($"gdt V{register.ToString("X")}");

            V[register] = delayTimer;

            pc += 2;
        }
    }
}
