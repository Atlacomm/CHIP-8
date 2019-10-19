using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Rnd(int register, byte value)
        {
            Console.WriteLine($"rnd V{register.ToString("X")}, {value}");

            Random random = new Random();

            byte rand = (byte)random.Next(byte.MaxValue+1);

            byte result = (byte)(rand & value);

            V[register] = result;

            pc += 2;
        }
    }
}
