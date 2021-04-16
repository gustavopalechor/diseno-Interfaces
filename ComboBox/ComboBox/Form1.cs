using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbIdiomas.Items.Add("Alemán");
            cbIdiomas.Items.Add("Ruso");

        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            cbIdiomas.Items.Add(txtIdioma.Text);
        }

        private void cbIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbIdiomas.SelectedIndex;
            lblIndice.Text = i.ToString();
            lblIdioma.Text = cbIdiomas.Items[i].ToString();
        }
    }
}
