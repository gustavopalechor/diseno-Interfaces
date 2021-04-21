using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDinamicos
{
    public partial class ControlesDinamicos : Form
    {
        private int x = 50;
        private int y = 50;
        private int i = 1;
        public ControlesDinamicos()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Button boton = new Button();
            boton.Height = 23;
            boton.Width = 100;
            boton.Location = new Point(x, y);
            boton.Name = "btnBoton" + i.ToString();
            boton.Text = "Botón #" + i.ToString();

            boton.Click += new EventHandler(handlerBotones_click);

            Controls.Add(boton);

            i++;
            y += 30;

        }

        private void handlerBotones_click(object sender, EventArgs e)
        {
            MessageBox.Show("Pulso el botón " + ((Button)sender).Text);
        }
    }
}
