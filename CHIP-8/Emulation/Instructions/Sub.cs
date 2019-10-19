using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sub(int registerX, int registerY)
        {
            bool borrow = false;

            Console.WriteLine($"sub V{registerX.ToString("X")}, V{registerY.ToString("X")}");

            int newVal = V[registerX] - V[registerY];
            while (newVal < 0)
            {
                newVal += byte.MaxValue;
                borrow = true;
            }

            V[registerX] = (byte)newVal;

            V[0xF] = borrow ? (byte)0 : (byte)1;

            pc += 2;
        }
    }
}
