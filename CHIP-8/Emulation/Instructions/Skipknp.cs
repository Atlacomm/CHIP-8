using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Skipknp(int register)
        {
            Console.WriteLine($"skipknp V{register.ToString("X")}");

            int key = V[register];

            // TODO: Implement logiv for pressing key (currently assuming key is not pressed)
            pc += 2;

            pc += 2;
        }
    }
}
