using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorEventos
{
    public partial class ManejadorEventos : Form
    {
        public ManejadorEventos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if (((Button)sender).Name == "btnUno")
            {
                lblMensaje.Text = ((Button)sender).Text;
               
            }
            if (((Button)sender).Name == "btnDos")
            {
                lblMensaje.Text = ((Button)sender).Text;
            }
            if (((Button)sender).Name == "btnTres")
            {
                lblMensaje.Text = ((Button)sender).Text;
                ((Button)sender).Text = "Hola";
            }
        }
    }
}
