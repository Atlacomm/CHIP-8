using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Jmp(ushort adress)
        {
            Console.WriteLine($"jmp {adress}");

            pc = adress;
        }
    }
}
