﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola mundo";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Adios mundo cruel";
            this.Text = "Adios carita de arroz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}
