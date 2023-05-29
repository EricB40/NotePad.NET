using NotePad.NET.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace NotePad.NET
{
    public partial class MainForm : Form
    {
        private readonly MenuStrip _mainMenuStrip;
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.Aqua; // Just here to see the menuStrip

            _mainMenuStrip = new MainMenuStrip();

            this.Controls.Add(_mainMenuStrip);
        }
    }
}
