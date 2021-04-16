using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es la ayuda pvto");
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double r = numero1 + numero2;

            lblResultado.Text = r.ToString();
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double r = numero1 - numero2;

            lblResultado.Text = r.ToString();
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double r = numero1 * numero2;

            lblResultado.Text = r.ToString();
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            if (numero2 <= 0)
            { lblResultado.Text = "0"; }
            else
            {
                double r = numero1 / numero2;

                lblResultado.Text = r.ToString();
            }
        }
    }
}
