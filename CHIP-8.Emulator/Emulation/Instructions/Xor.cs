﻿using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Xor(int registerX, int registerY)
        {
            Console.WriteLine($"xor V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            byte val1 = V[registerX];
            byte val2 = V[registerY];

            byte result = (byte)(val1 ^ val2);

            V[registerX] = result;

            pc += 2;
        }
    }
}
