using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double r = 0;

            if (rbSuma.Checked == true)
            {
                r = numero1 + numero2;

            }
            if (rbResta.Checked == true)
            {
                r = numero1 - numero2;

            }
            if (rbMultiplicacion.Checked == true)
            {
                r = numero1 * numero2;

            }
            if (rbDivision.Checked == true)
            {
                if (numero2 <= 0)
                {
                    r = 0;
                }
                else
                {
                    r = numero1 / numero2;
                }

            }
            MessageBox.Show("El resultado es: " + r.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }
    }
}
