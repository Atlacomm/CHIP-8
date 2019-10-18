using System.Windows.Forms;

namespace CHIP8.Controls
{
    public partial class KeyQuery : UserControl
    {
        public bool Querying { get; private set; } = false;

        public event KeyEventHandler KeySelected;

        public override string Text
        {
            get
            {
                return labelText.Text;
            }
            set
            {
                labelText.Text = value;
            }
        }

        public KeyQuery()
        {
            InitializeComponent();
        }

        private void KeyQuery_MouseClick(object sender, MouseEventArgs e)
        {
            Querying = true;
            labelPressAKey.Visible = true;
        }

        private void KeyQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (Querying)
            {
                KeySelected?.Invoke(this, e);
                Querying = false;
                labelPressAKey.Visible = false;
            }
        }
    }
}
