using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiBoton
{
    class MiBoton : Button
    {
        private bool crece = true;
        [Description("Indica si el boton crece")]
        [Category("Nuevas propiedades")]
        [DefaultValue(true)]

        public bool Crece
        {
            get{return crece;}
            set { crece = value; }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (crece)
            {
                this.Size = new System.Drawing.Size(200, 100);
            }
            base.OnMouseEnter(e);
        }

    }
}
