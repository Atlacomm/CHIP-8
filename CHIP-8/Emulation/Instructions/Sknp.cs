using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sknp(int register)
        {
            Console.WriteLine($"sknp V{register.ToString("X")}");

            int key = V[register];

            if (!mainWindow.buttonsDown[key])
            {
                pc += 2;
            }
            // TODO: Implement logic for pressing key (currently assuming key is not pressed)
            
            pc += 2;
        }
    }
}
