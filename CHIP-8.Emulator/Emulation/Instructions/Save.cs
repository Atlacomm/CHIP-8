using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Save(int register)
        {
            Console.WriteLine($"save V{register.ToString("X")}");

            for (int i = 0; i <= register; i++)
            {
                emulator.memory[I + i] = V[i];
            }

            pc += 2;
        }
    }
}
