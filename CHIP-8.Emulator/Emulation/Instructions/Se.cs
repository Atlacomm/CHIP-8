using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Se(int registerX, int registerY)
        {
            Console.WriteLine($"sei V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            if (V[registerX] == V[registerY]) pc += 2;

            pc += 2;
        }
    }
}
