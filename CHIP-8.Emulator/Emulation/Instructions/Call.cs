using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Call(ushort adress)
        {
            Console.WriteLine($"call {adress}");

            stack[sp] = (ushort)(pc + 2);
            sp++;

            pc = adress;
        }
    }
}
