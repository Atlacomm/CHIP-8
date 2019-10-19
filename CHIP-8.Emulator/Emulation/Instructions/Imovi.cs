using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Imovi(ushort value)
        {
            Console.WriteLine($"imovi {value}");

            I = value;

            pc += 2;
        }
    }
}
