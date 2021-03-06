﻿using System;
using System.IO;
using System.Media;
using static CHIP8.Program;

namespace CHIP8.Emulation
{
    partial class CPU : IDisposable
    {
        // TODO: Implement user definable clock speed
        public const int CLOCKSPEED = 500;

        // TODO: Implement user definable step mode
        const bool STEPMODE = false;

        Emulator emulator;

        byte[] V = null;
        ushort I = 0;

        ushort[] stack = null;
        int sp = 0;

        byte delayTimer = 0;
        byte soundTimer = 0;

        ushort pc = 512;

        SoundPlayer soundPlayer;
        Stream soundStream;

        bool playing = false;

        public CPU(Emulator emulator)
        {
            this.emulator = emulator;

            V = new byte[16];
            stack = new ushort[32];

            soundPlayer = new SoundPlayer();
            soundStream = Properties.Resources.beep;

            soundPlayer.Stream = soundStream;
            soundPlayer.Load();
        }

        public void UpdateTimers()
        {
            if (delayTimer > 0) delayTimer--;
            if (soundTimer > 0) soundTimer--;
            else
            {
                soundPlayer.Stop();
                playing = false;
            }

            if (soundTimer > 0 && !playing && settings.Sound)
            {
                playing = true;
                soundPlayer?.PlayLooping();
            }
        }

        public void EmulateCycle()
        {
            ushort opcode = (ushort)((emulator.memory[pc] << 8) | emulator.memory[pc + 1]);
            bool foundCode = true;

            // Decode a given opcode and call it's corresponding function
            switch (opcode & 0xF000)
            {
                case 0x0000:
                    switch (opcode)
                    {
                        case 0x00EE: // 00EE - Return from a subroutine
                            Ret();
                            break;
                        case 0x00E0:
                            Clr();
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
                    break;
                case 0x1000: // 1NNN - Jump to adress NNN
                    Jmp((ushort)(opcode & 0x0FFF));
                    break;
                case 0x2000: // 2NNN - Call subroutine at NNN
                    Call((ushort)(opcode & 0x0FFF));
                    break;
                case 0x3000: // 3XNN - Skip next instruction if VX == NN
                    Sei((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0x4000: // 4XNN - Skip next instruction if VX != NN
                    Snei((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0x5000: // 5XY0 - Skip next instruction if VX == VY
                    Se((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                    break;
                case 0x6000: // 6XNN - Set VX to NN
                    Movi((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0x7000: // 7XNN - Add NN to VX
                    Addi((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0x8000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0000: // 8XY0 - VX = VY
                            Mov((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0001: // 8XY1 - VX = VX or VY (bitwise)
                            Or((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0002: // 8XY2 - VX = VX and VY (bitwise)
                            And((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0003: // 8XY3 - VX = VX xor VY (bitwise)
                            Xor((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0004: // 8XY4 - Add VY to VX and set VF to 1 if there is a carry and set it to 0 if there isn't
                            Add((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0005: // 8XY5 - Subtract VY from VX and if there is a borrow set VF to 0 else set VF to 1
                            Sub((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x0006: // 8XY6 - Store the least significant bit of VX in VF and shift VX to the right by 1
                            Lsb((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0007: // 8XY7 - VX = VY - VX. VF = 0 when there's a borrow else VF = 1
                            Suba((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                            break;
                        case 0x000E: // 8XYE - Store the most significant bit of VX in VF and shift VX to the left by 1
                            Msb((opcode & 0x0F00) >> 8);
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
                    break;
                case 0x9000: // 9XY0 - Skip next instruction if VX != VY
                    Sne((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4);
                    break;
                case 0xA000: // ANNN - Set I to the address NNN
                    Imovi((ushort)(opcode & 0x0FFF));
                    break;
                case 0xB000: // BNNN - Jump to NNN + V0
                    Jmpa((ushort)(opcode & 0x0FFF));
                    break;
                case 0xC000: // CXNN - Set VX to the result of a bitwise and operation with NN and a random number ranging from 0 to 255
                    Rnd((opcode & 0x0F00) >> 8, (byte)(opcode & 0x00FF));
                    break;
                case 0xD000: // DXYN - Draw sprite at (VX, VY); Size 8xN; Data starts at I; If pixels are flipped to off VF=1 else VF=0
                    Sprite((opcode & 0x0F00) >> 8, (opcode & 0x00F0) >> 4, (byte)(opcode & 0x000F));
                    break;
                case 0xE000:
                    switch (opcode & 0x00FF)
                    {
                        case 0x00A1: // EXA1 - Skip next instruction if key in VX is not pressed (TODO: Actually implement key check)
                            Sknp((opcode & 0x0F00) >> 8);
                            break;
                        case 0x009E: // EX9E - Skip next instruction if key in VX is pressed (TODO: Actually implement key check)
                            Skp((opcode & 0x0F00) >> 8);
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
                    break;
                case 0xF000:
                    switch (opcode & 0x00FF)
                    {
                        case 0x0007: // FX07 - Set VX to delay timer
                            Gdt((opcode & 0x0F00) >> 8);
                            break;
                        case 0x000A: // FX0A - Wait for key press and store it in VX (BLOCKING CALL)
                            Key((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0015: // FX15 - Set the delay timer to VX
                            Sdt((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0018: // FX18 - Set sound timer to VX
                            Sst((opcode & 0x0F00) >> 8);
                            break;
                        case 0x001E: // FX1E - Add VX to I
                            Iadd((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0029: // FX29 - Set I to the location of the sprite for the character in VX.
                            SpriteAddr((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0033: // FX33 - Store binary-coded decimal representation of VX at I, I + 1 and I + 3
                            Bcd((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0055: // FX55 - Store V0 to VX (including VX) in memory starting at address I
                            Save((opcode & 0x0F00) >> 8);
                            break;
                        case 0x0065: // FX65 - Fill V0 to VX (including VX) with memory starting at I. Offset increases by 1 for each value; I unmodified.
                            Load((opcode & 0x0F00) >> 8);
                            break;
                        default:
                            foundCode = false;
                            break;
                    }
                    break;
                default:
                    foundCode = false;
                    break;
            }

            if (!foundCode)
            {
                Console.WriteLine("Unknown opcode: 0x" + opcode.ToString("X4"));
                pc += 2;
            }
        }

        public void Dispose()
        {
            soundPlayer.Dispose();
            soundStream.Dispose();
        }
    }
}
