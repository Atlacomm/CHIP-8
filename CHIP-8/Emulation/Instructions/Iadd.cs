using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Iadd(int register)
        {
            Console.WriteLine($"iadd V{register.ToString("X")}");

            I += V[register];

            pc += 2;
        }
    }
}
