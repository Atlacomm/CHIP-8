using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Ret()
        {
            Console.WriteLine($"ret");

            sp--;
            pc = stack[sp];
        }
    }
}
