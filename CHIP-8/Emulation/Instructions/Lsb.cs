using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Lsb(int register)
        {
            Console.WriteLine($"lsb V{register.ToString("X")}");

            string bin = Convert.ToString(V[register], 2);

            V[0xF] = Convert.ToByte(bin[bin.Length - 1].ToString(), 2);

            V[register] = (byte)(V[register] >> 1);

            pc += 2;
        }
    }
}
