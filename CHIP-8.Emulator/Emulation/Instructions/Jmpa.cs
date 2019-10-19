using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Jmpa(ushort value)
        {
            Console.WriteLine($"jmpa {value}");

            pc = (ushort)(V[0] + value);

            pc += 2;
        }
    }
}
