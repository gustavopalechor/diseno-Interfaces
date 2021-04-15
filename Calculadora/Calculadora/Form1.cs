using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            double r = numero1 - numero2;

            lblResultado.Text = r.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSimbolo.Text = "=";
            lblResultado.Text = "";

            txtNumero1.Text="0";
            txtNumero2.Text = "0";


        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            double r = numero1 + numero2;

            lblResultado.Text = r.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double r;

            if (numero2 <= 0)
            {
                lblResultado.Text = "finito";
            }
            else
            {
                r = numero1 / numero2;
                lblResultado.Text = r.ToString();
            }

           
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            double r = numero1 * numero2;

            lblResultado.Text = r.ToString();

        }
    }
}
