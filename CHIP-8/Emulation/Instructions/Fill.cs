using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Fill(int register)
        {
            Console.WriteLine($"fill V{register.ToString("X")}");

            for (int i = 0; i <= register; i++)
            {
                V[i] = emulator.memory[I + i];
            }

            pc += 2;
        }
    }
}
