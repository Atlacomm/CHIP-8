using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void IMov(ushort value)
        {
            Console.WriteLine($"imov {value}");

            I = value;

            pc += 2;
        }
    }
}
