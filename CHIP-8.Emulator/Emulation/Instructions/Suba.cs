using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Suba(int registerX, int registerY)
        {
            Console.WriteLine($"suba V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            bool borrow = false;

            if (V[registerY] - V[registerX] < 0) borrow = true;

            V[registerX] = (byte)(V[registerY] - V[registerX]);

            V[0xF] = borrow ? (byte)0 : (byte)1;

            pc += 2;
        }
    }
}
