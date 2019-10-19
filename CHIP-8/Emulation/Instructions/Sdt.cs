using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sdt(int register)
        {
            Console.WriteLine($"sdt V{register.ToString("X")}");

            delayTimer = V[register];

            pc += 2;
        }
    }
}
