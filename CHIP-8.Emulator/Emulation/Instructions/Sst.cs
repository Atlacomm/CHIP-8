using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sst(int register)
        {
            Console.WriteLine($"sst V{register.ToString("X")}");

            soundTimer = V[register];

            pc += 2;
        }
    }
}
