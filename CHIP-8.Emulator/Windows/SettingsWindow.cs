using CHIP8.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static CHIP8.Program;

namespace CHIP8.Windows
{
    partial class SettingsWindow : Form
    {
        List<KeyQuery> keyQueries;

        Settings tempSettings = new Settings();

        public SettingsWindow()
        {
            InitializeComponent();

            keyQueries = groupBoxInput.Controls.OfType<KeyQuery>().ToList();

            tempSettings.Buttons = new List<Keys>(settings.Buttons).ToArray();

            keyQuery0.Text = tempSettings.Buttons[0x0].ToString();
            keyQuery1.Text = tempSettings.Buttons[0x1].ToString();
            keyQuery2.Text = tempSettings.Buttons[0x2].ToString();
            keyQuery3.Text = tempSettings.Buttons[0x3].ToString();
            keyQuery4.Text = tempSettings.Buttons[0x4].ToString();
            keyQuery5.Text = tempSettings.Buttons[0x5].ToString();
            keyQuery6.Text = tempSettings.Buttons[0x6].ToString();
            keyQuery7.Text = tempSettings.Buttons[0x7].ToString();
            keyQuery8.Text = tempSettings.Buttons[0x8].ToString();
            keyQuery9.Text = tempSettings.Buttons[0x9].ToString();
            keyQueryA.Text = tempSettings.Buttons[0xA].ToString();
            keyQueryB.Text = tempSettings.Buttons[0xB].ToString();
            keyQueryC.Text = tempSettings.Buttons[0xC].ToString();
            keyQueryD.Text = tempSettings.Buttons[0xD].ToString();
            keyQueryE.Text = tempSettings.Buttons[0xE].ToString();
            keyQueryF.Text = tempSettings.Buttons[0xF].ToString();
        }

        private void keyQuery_KeySelected(object sender, KeyEventArgs e)
        {
            foreach (KeyQuery query in keyQueries)
            {
                if (query != (KeyQuery)sender)
                {
                    query.Enabled = true;
                }
            }

            KeyQuery q = (KeyQuery)sender;
            q.Text = e.KeyCode.ToString();

            if (q == keyQuery0)
            {
                tempSettings.Buttons[0x0] = e.KeyCode;
            }
            else if (q == keyQuery1)
            {
                tempSettings.Buttons[0x1] = e.KeyCode;
            }
            else if (q == keyQuery2)
            {
                tempSettings.Buttons[0x2] = e.KeyCode;
            }
            else if (q == keyQuery3)
            {
                tempSettings.Buttons[0x3] = e.KeyCode;
            }
            else if (q == keyQuery4)
            {
                tempSettings.Buttons[0x4] = e.KeyCode;
            }
            else if (q == keyQuery5)
            {
                tempSettings.Buttons[0x5] = e.KeyCode;
            }
            else if (q == keyQuery6)
            {
                tempSettings.Buttons[0x6] = e.KeyCode;
            }
            else if (q == keyQuery7)
            {
                tempSettings.Buttons[0x7] = e.KeyCode;
            }
            else if (q == keyQuery8)
            {
                tempSettings.Buttons[0x8] = e.KeyCode;
            }
            else if (q == keyQuery9)
            {
                tempSettings.Buttons[0x9] = e.KeyCode;
            }
            else if (q == keyQueryA)
            {
                tempSettings.Buttons[0xA] = e.KeyCode;
            }
            else if (q == keyQueryB)
            {
                tempSettings.Buttons[0xB] = e.KeyCode;
            }
            else if (q == keyQueryC)
            {
                tempSettings.Buttons[0xC] = e.KeyCode;
            }
            else if (q == keyQueryD)
            {
                tempSettings.Buttons[0xD] = e.KeyCode;
            }
            else if (q == keyQueryE)
            {
                tempSettings.Buttons[0xE] = e.KeyCode;
            }
            else if (q == keyQueryF)
            {
                tempSettings.Buttons[0xF] = e.KeyCode;
            }
        }

        private void keyQuery_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (KeyQuery query in keyQueries)
            {
                if (query != (KeyQuery)sender)
                {
                    query.Enabled = false;
                }
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            settings.Buttons = new List<Keys>(tempSettings.Buttons).ToArray();
            settings.SaveToFile(SETTINGSFILE);
            Close();
        }
    }
}
