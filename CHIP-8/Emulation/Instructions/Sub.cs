﻿using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sub(int registerX, int registerY)
        {
            bool borrow = false;

            Console.WriteLine($"sub V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            if (V[registerX] - V[registerY] < 0) borrow = true;

            V[registerX] -= V[registerY];

            V[0xF] = borrow ? (byte)0 : (byte)1;

            pc += 2;
        }
    }
}
