using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola desde Windows Form");
            //MessageBox.Show("Hola desde Windows Form", "alerta");
            /*DialogResult r= MessageBox.Show("Hola desde Windows Form", "alerta", MessageBoxButtons.AbortRetryIgnore);
            if (r == DialogResult.Abort) { lblMensaje.Text = "Abortar el proceso"; }
            if (r == DialogResult.Retry) { lblMensaje.Text = "Reintentar el proceso"; }
            if (r == DialogResult.Ignore) { lblMensaje.Text = "Ignorar el proceso"; }*/
            DialogResult r = MessageBox.Show("Hola desde Windows Form", "alerta", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
        }
    }
}
