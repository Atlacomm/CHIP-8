using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Mov(int registerX, int registerY)
        {
            Console.WriteLine($"mov V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            V[registerX] = V[registerY];

            pc += 2;
        }
    }
}
