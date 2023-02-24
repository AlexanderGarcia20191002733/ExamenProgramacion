using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetsonCanales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void programa3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multiplos fm3 = new Multiplos();
            fm3.Show();
        }

        private void programa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion fm2 = new Facturacion();
            fm2.Show();
        }

        private void programa2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Facturacion fm2 = new Facturacion();
            fm2.Show();
        }

        private void programa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intereses fm1 = new Intereses();
            fm1.Show();
        }
    }
}
