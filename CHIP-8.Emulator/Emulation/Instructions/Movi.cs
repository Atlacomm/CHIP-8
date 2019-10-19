using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Movi(int register, byte value)
        {
            Console.WriteLine($"movi V{register.ToString("X")}, {value}");

            V[register] = value;

            pc += 2;
        }
    }
}
