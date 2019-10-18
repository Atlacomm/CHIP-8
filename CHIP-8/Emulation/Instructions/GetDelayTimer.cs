using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void GetDelayTimer(int register)
        {
            V[register] = delayTimer;

            pc += 2;
        }
    }
}
