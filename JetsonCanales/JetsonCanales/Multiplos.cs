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
    public partial class Multiplos : Form
    {
        public Multiplos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista();
        }
        void Lista()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ListaNumeros.Items.Add("Jetson Garcia");
                }
                else if (i % 3 == 0)
                {
                    ListaNumeros.Items.Add("Alexander");
                }
                else if (i % 5 == 0)
                {
                    ListaNumeros.Items.Add("Canales");
                }
                else
                {
                    ListaNumeros.Items.Add(i);
                }
            }
        }
    }
}
