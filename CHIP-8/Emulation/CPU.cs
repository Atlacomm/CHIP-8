namespace CHIP8.Emulation
{
    class CPU
    {
        // TODO: Implement user definable clock speed
        public const int CLOCKSPEED = 500;

        Emulator emulator;

        byte[] V = null;
        ushort I = 0;

        ushort[] stack = null;

        byte delayTimer = 0;
        byte soundTimer = 0;

        ushort pc = 512;

        public CPU(Emulator emulator)
        {
            this.emulator = emulator;

            V = new byte[16];
            stack = new ushort[32];
        }

        public void UpdateTimers()
        {
            if (delayTimer > 0) delayTimer--;
            if (soundTimer > 0) soundTimer--;

            // TODO: Make a beep when sound timer is not zero
        }

        public void EmulateCycle()
        {
            
        }
    }
}
