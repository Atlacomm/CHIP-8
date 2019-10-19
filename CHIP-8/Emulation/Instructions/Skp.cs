using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Skp(int register)
        {
            Console.WriteLine($"skp V{register.ToString("X")}");

            int key = V[register];

            if (mainWindow.buttonsDown[key])
            {
                pc += 2;
            }
            
            pc += 2;
        }
    }
}
