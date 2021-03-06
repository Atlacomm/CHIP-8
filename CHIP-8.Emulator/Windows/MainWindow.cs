﻿using CHIP8.Emulation;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static CHIP8.Program;

namespace CHIP8.Windows
{
    partial class MainWindow : Form
    {
        Emulator emulator = null;

        public bool[] buttonsDown { get; private set; } = new bool[settings.Buttons.Length];

        public MainWindow()
        {
            InitializeComponent();

            // Set the window size
            int scale = 10;
            ClientSize = new Size(SCREENWIDTH * scale, SCREENHEIGHT * scale);

            // Initialize button state
            for (int i = 0; i < buttonsDown.Length; i++) buttonsDown[i] = false;

            menuOptions_Sound.Checked = settings.Sound;
        }

        // Setup OpenGL
        private void glControl_Load(object sender, System.EventArgs e)
        {
            GL.Viewport(new Rectangle(new Point(0, 0), new Size(640, 320)));

            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        // Render OpenGL stuff
        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            glControl.SwapBuffers();
        }

        // Prompt the emulation to stop and wait for it to do so before exiting
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonsDown[0] = true;

            // Wait for the emulation thread to end
            emulator?.WaitForEnd();

            // If the emulation does not end for some reason force it
            emulator?.Kill();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        // Handle loading a file
        private void menuFile_Open_Click(object sender, System.EventArgs e)
        {
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
                    emulator?.WaitForEnd();
                    emulator?.Kill();
                    GC.Collect();
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

        private void glControl_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < settings.Buttons.Length; i++)
            {
                if (settings.Buttons[i] == e.KeyCode)
                {
                    buttonsDown[i] = true;
                }
            }
        }

        private void glControl_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < settings.Buttons.Length; i++)
            {
                if (settings.Buttons[i] == e.KeyCode)
                {
                    buttonsDown[i] = false;
                }
            }
        }

        private void menuOptions_Sound_Click(object sender, EventArgs e)
        {
            if (!menuOptions_Sound.Checked)
            {
                menuOptions_Sound.Checked = true;
            }
            else
            {
                menuOptions_Sound.Checked = false;
                
            }

            settings.Sound = menuOptions_Sound.Checked;
            settings.SaveToFile(SETTINGSFILE);
        }
    }
}
