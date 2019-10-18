using System.Windows.Forms;

namespace CHIP8.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFile_Open = new System.Windows.Forms.MenuItem();
            this.menuFile_Divider0 = new System.Windows.Forms.MenuItem();
            this.menuFile_Exit = new System.Windows.Forms.MenuItem();
            this.menuOptions = new System.Windows.Forms.MenuItem();
            this.menuOptions_Settings = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuHelp_About = new System.Windows.Forms.MenuItem();
            this.glControl = new OpenTK.GLControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile_Open,
            this.menuFile_Divider0,
            this.menuFile_Exit});
            this.menuFile.Text = "File";
            // 
            // menuFile_Open
            // 
            this.menuFile_Open.Index = 0;
            this.menuFile_Open.Text = "Open";
            this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // menuFile_Divider0
            // 
            this.menuFile_Divider0.Index = 1;
            this.menuFile_Divider0.Text = "-";
            // 
            // menuFile_Exit
            // 
            this.menuFile_Exit.Index = 2;
            this.menuFile_Exit.Text = "Exit";
            this.menuFile_Exit.Click += new System.EventHandler(this.menuFile_Exit_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.Index = 1;
            this.menuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOptions_Settings});
            this.menuOptions.Text = "Options";
            // 
            // menuOptions_Settings
            // 
            this.menuOptions_Settings.Index = 0;
            this.menuOptions_Settings.Text = "Settings";
            this.menuOptions_Settings.Click += new System.EventHandler(this.menuOptions_Settings_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelp_About});
            this.menuHelp.Text = "Help";
            // 
            // menuHelp_About
            // 
            this.menuHelp_About.Index = 0;
            this.menuHelp_About.Text = "About";
            this.menuHelp_About.Click += new System.EventHandler(this.menuHelp_About_Click);
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(256, 128);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files|*.*";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(256, 128);
            this.Controls.Add(this.glControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "CHIP-8 Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenu mainMenu;
        private MenuItem menuFile;
        private MenuItem menuFile_Open;
        private MenuItem menuFile_Divider0;
        private MenuItem menuOptions;
        private MenuItem menuOptions_Settings;
        private MenuItem menuFile_Exit;
        private MenuItem menuHelp;
        private MenuItem menuHelp_About;
        public OpenTK.GLControl glControl;
        private OpenFileDialog openFileDialog;
    }
}