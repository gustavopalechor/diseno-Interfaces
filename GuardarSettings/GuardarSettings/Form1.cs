using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuardarSettings.Properties;


namespace GuardarSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                Settings.Default["Genero"] = 2;
                Settings.Default.Save();
            }
        }

        private void cbIngles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Text = (string)Settings.Default["Nombre"];
            cbEspanol.Checked = (bool)Settings.Default["Espanol"];
            cbIngles.Checked = (bool)Settings.Default["Ingles"];

            switch ((int)Settings.Default["Genero"])
            {
                case 0:
                    rbMasculino.Checked = true;
                    rbFemenino.Checked = false;
                    rbOtro.Checked = false;
                    break;
                case 1:
                    rbMasculino.Checked = false;
                    rbFemenino.Checked = true;
                    rbOtro.Checked = false;
                    break;
                case 2:
                    rbMasculino.Checked = false;
                    rbFemenino.Checked = false;
                    rbOtro.Checked = true;
                    break;

            }


        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Nombre"] = txtNombre.Text;
            Settings.Default.Save();
        }

        private void cbEspanol_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Espanol"] = cbEspanol.Checked;
            
            Settings.Default.Save();
        }

        private void cbIngles_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Ingles"] = cbIngles.Checked;
            Settings.Default.Save();
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == true)
            {
                Settings.Default["Genero"] = 0;
                Settings.Default.Save();
            }
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked == true)
            {
                Settings.Default["Genero"] = 1;
                Settings.Default.Save();
            }
        }
    }
}
