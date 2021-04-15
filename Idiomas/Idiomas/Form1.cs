using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idiomas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkEspanol.Checked == true)
            {
                total++;
            }
            if (chkIngles.Checked == true)
            {
                total++;
            }
            if (chkFrances.Checked == true)
            {
                total++;
            }
            if (total == 0)
            {
                MessageBox.Show("Debes seleccion un idioma");
            }
            else
            {
                MessageBox.Show("Hablas " + total.ToString() + " idiomas");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            lblSelecciona.Text = "Selecciona los mensajes que sepas";
        }
    }
}
