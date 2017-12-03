using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class frmButtons : Form
    {
        public frmButtons()
        {
            InitializeComponent();
        }

        private void cmdPositionRel_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(
                cmdTest.Location.X + 20, cmdTest.Location.Y);
        }

        private void cmdPositionAbs_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(100, 200);
        }

        private void cmdSizeRel_Click(object sender, EventArgs e)
        {
            cmdTest.Size = new Size(
                cmdTest.Size.Width + 20, cmdTest.Size.Height);
        }

        private void cmdSizeAbs_Click(object sender, EventArgs e)
        {
            cmdTest.Size = new Size(50, 100);
        }

        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Position: X: " + cmdTest.Location.X + ", Y: " + cmdTest.Location.Y + "\n"
                + "Grösse: Breite: " + cmdTest.Size.Width + ", Höhe: " + cmdTest.Size.Height;
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            lblAnzeige.BackColor = Color.FromArgb(192, 255, 0);
        }
    }
}
