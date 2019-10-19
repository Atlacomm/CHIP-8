using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        Random random = new Random();

        private void Rnd(int register, byte value)
        {
            Console.WriteLine($"rnd V{register.ToString("X")}, {value}");
            
            byte rand = (byte)random.Next(byte.MaxValue+1);

            byte result = (byte)(rand & value);

            Console.WriteLine(result);
            V[register] = result;

            pc += 2;
        }
    }
}
