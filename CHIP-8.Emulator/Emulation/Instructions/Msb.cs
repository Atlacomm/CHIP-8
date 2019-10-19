using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Msb(int register)
        {
            Console.WriteLine($"msb V{register.ToString("X")}");

            string bin = Convert.ToString(V[register], 2);

            V[0xF] = Convert.ToByte(bin[0].ToString(), 2);

            V[register] = (byte)(V[register] << 1);

            pc += 2;
        }
    }
}
