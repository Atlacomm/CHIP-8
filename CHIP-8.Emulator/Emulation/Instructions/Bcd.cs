using System;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Bcd(int register)
        {
            Console.WriteLine($"bcd V{register.ToString("X")}");

            int number = V[register];

            string str = number.ToString();
            while (str.Length < 3) str = "0" + str;

            emulator.memory[I] = Convert.ToByte(str[0].ToString());
            emulator.memory[I + 1] = Convert.ToByte(str[1].ToString());
            emulator.memory[I + 2] = Convert.ToByte(str[2].ToString());

            pc += 2;
        }
    }
}
