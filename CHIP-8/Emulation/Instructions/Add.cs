using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Add(int registerX, int registerY)
        {
            bool carry = false;

            Console.WriteLine($"add V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            int newVal = V[registerX] + V[registerY];
            while (newVal > byte.MaxValue)
            {
                newVal -= byte.MaxValue;
                carry = true;
            }

            V[registerX] = (byte)newVal;

            V[0xF] = carry ? (byte)1 : (byte)0;

            pc += 2;
        }
    }
}
