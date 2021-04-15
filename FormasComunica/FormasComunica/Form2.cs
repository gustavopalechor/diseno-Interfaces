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
    

    public partial class Form2 : Form
    {
        
        public Form2(string mensaje)
        {
            InitializeComponent();
            
            lblMensaje.Text = mensaje;
            string propiedad1;
        public string propiedad
        {
            set
            {
                propiedad = value;
                lblPropiedad.Text = propiedad1;
            }

        }


    }
        

        
    }
}
