using CHIP8.Windows;
using System;
using System.IO;
using System.Windows.Forms;

namespace CHIP8
{
    static class Program
    {
        // Screen size
        public const int SCREENWIDTH = 64;
        public const int SCREENHEIGHT = 32;

        public const string SETTINGSFILE = "chip8.cfg";

        public static Settings settings = null;

        public static MainWindow mainWindow;

        [STAThread]
        static void Main(string[] args)
        {
            if (File.Exists(SETTINGSFILE))
            {
                settings = Settings.LoadFromFile(SETTINGSFILE);
            }
            else
            {
                settings = new Settings();
                settings.SaveToFile(SETTINGSFILE);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainWindow = new MainWindow();
            Application.Run(mainWindow);
            mainWindow.Dispose();
        }
    }
}
