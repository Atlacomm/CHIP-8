using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Clr()
        {
            Console.WriteLine($"clr");

            for (int i = 0; i < emulator.frameBuffer.Length; i++)
            {
                emulator.frameBuffer[i] = false;
            }

            pc += 2;
        }
    }
}
