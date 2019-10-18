using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIP8.Emulation
{
    class CPU
    {
        byte[] memory = null;

        public CPU(byte[] memory)
        {
            this.memory = memory;
        }
    }
}
