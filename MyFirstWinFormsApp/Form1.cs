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
    public partial class frmHallo : Form
    {
        public frmHallo()
        {
            InitializeComponent();
        }

        private void cmdHallo_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Hallo";
        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
