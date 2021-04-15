using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasComunica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2(txtMensaje.Text);
            forma2.ShowDialog();
            forma2.propiedad1 = "Hola, cara de bola";
        }
    }
}
