using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Key(int register)
        {
            Console.WriteLine($"key V{register.ToString("X")}");

            bool keyPressed = false;

            while (!keyPressed)
            {
                for (byte i = 0; i < mainWindow.buttonsDown.Length; i++)
                {
                    if (mainWindow.buttonsDown[i] == true)
                    {
                        V[register] = i;
                        keyPressed = true;

                        mainWindow.buttonsDown[i] = false;
                    }
                }
            }
            
            pc += 2;
        }
    }
}
