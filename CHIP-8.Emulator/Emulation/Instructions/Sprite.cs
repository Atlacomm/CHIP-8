using System;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU
    {
        private void Sprite(int registerX, int registerY, byte height)
        {
            Console.WriteLine($"sprite V{registerX.ToString("X")}, V{registerY.ToString("X")}, {height}");

            byte x = V[registerX];
            byte y = V[registerY];

            byte[] spriteData = new byte[height];
            for (int i = 0; i < spriteData.Length; i++) spriteData[i] = emulator.memory[I + i];

            bool flippedToOff = false;

            for (int yy = 0; yy < spriteData.Length; yy++)
            {
                string currentRow = Convert.ToString(spriteData[yy], 2);
                while (currentRow.Length < 8) currentRow = "0" + currentRow;
                for (int xx = 0; xx < currentRow.Length; xx++)
                {
                    int newX = x + xx;
                    int newY = y + yy;

                    if (newX < SCREENWIDTH && newY < SCREENHEIGHT && newX >= 0 && newY >= 0 && currentRow[xx] == '1')
                    {
                        int index = newX + newY * SCREENWIDTH;

                        emulator.frameBuffer[index] = !emulator.frameBuffer[index];

                        bool newVal = emulator.frameBuffer[index];
                        if (newVal == false) flippedToOff = true;
                    }
                }
            }

            if (flippedToOff) V[0xF] = 1;
            else V[0xF] = 0;

            pc += 2;
        }
    }
}
