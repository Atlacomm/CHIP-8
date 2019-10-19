using System;
using System.Drawing;
using System.Windows.Forms;

namespace CHIP8.Windows
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            Location = new Point(0, 0);
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}
