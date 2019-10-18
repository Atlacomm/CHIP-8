using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using CHIP8.Emulation;
using System.IO;
using System;

namespace CHIP8.Windows
{
    partial class MainWindow : Form
    {
        const int SCREENWIDTH = 64;
        const int SCREENHEIGHT = 32;

        Emulator emulator = null;

        public MainWindow()
        {
            InitializeComponent();

            // Set the window size
            int scale = 10;
            ClientSize = new Size(SCREENWIDTH * scale, SCREENHEIGHT * scale);
        }
        // Setup OpenGL
        private void glControl_Load(object sender, System.EventArgs e)
        {
            GL.Viewport(new Rectangle(new Point(0, 0), new Size(640, 320)));

            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        // Render OpenGL stuff
        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            // Swap the buffers so the image is displayed
            glControl.SwapBuffers();
        }

        // Prompt the emulation to stop and wait for it to do so before exiting
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            emulator?.WaitForEnd();
        }

        // Handle loading a file
        private void menuFile_Open_Click(object sender, System.EventArgs e)
        {
            emulator?.WaitForEnd();

            // Prompt the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // If the user successfully selceted a file get the path
                string path = openFileDialog.FileName;

                // Check if the file fits into a byte array
                if (new FileInfo(path).Length <= int.MaxValue)
                {
                    byte[] rom = File.ReadAllBytes(path);

                    // Create an emulator
                    emulator = new Emulator(rom);
                }
            }
        }

        // Close this form
        private void menuFile_Exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        // Open the settings dialog
        private void menuOptions_Settings_Click(object sender, System.EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.StartPosition = FormStartPosition.CenterParent;
            settingsWindow.ShowDialog();
            settingsWindow.Dispose();
        }

        // Open the about window
        private void menuHelp_About_Click(object sender, System.EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.StartPosition = FormStartPosition.CenterParent;
            aboutWindow.ShowDialog();
            aboutWindow.Dispose();
        }
    }
}
