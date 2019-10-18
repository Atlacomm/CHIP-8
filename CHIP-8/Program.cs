using System;
using System.IO;
using System.Windows.Forms;
using CHIP8.Windows;

namespace CHIP8
{
    static class Program
    {
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
