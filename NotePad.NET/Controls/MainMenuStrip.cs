using System.Windows.Forms;

namespace NotePad.NET.Controls
{
    internal class MainMenuStrip : MenuStrip
    {
        public MainMenuStrip()
        {
            Name = "MainMenuStrip";
            /* Since it's inheriting from MenuStrip we can acces and filter all properties through Intellisense.*/
            Dock = DockStyle.Top;
            //-------------------------------------------------------------------------------------------------
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Fichier");
            this.Items.Add(fileMenu);


        }
    }
}
