namespace Idiomas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkEspanol = new System.Windows.Forms.CheckBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkFrances = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblSelecciona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkEspanol
            // 
            this.chkEspanol.AutoSize = true;
            this.chkEspanol.Location = new System.Drawing.Point(317, 118);
            this.chkEspanol.Name = "chkEspanol";
            this.chkEspanol.Size = new System.Drawing.Size(81, 21);
            this.chkEspanol.TabIndex = 0;
            this.chkEspanol.Text = "Español";
            this.chkEspanol.UseVisualStyleBackColor = true;
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(317, 167);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(67, 21);
            this.chkIngles.TabIndex = 1;
            this.chkIngles.Text = "Ingles";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // chkFrances
            // 
            this.chkFrances.AutoSize = true;
            this.chkFrances.Location = new System.Drawing.Point(317, 219);
            this.chkFrances.Name = "chkFrances";
            this.chkFrances.Size = new System.Drawing.Size(81, 21);
            this.chkFrances.TabIndex = 2;
            this.chkFrances.Text = "Frances";
            this.chkFrances.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(486, 167);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(46, 17);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(489, 219);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblSelecciona
            // 
            this.lblSelecciona.AutoSize = true;
            this.lblSelecciona.Location = new System.Drawing.Point(317, 52);
            this.lblSelecciona.Name = "lblSelecciona";
            this.lblSelecciona.Size = new System.Drawing.Size(46, 17);
            this.lblSelecciona.TabIndex = 5;
            this.lblSelecciona.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelecciona);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkFrances);
            this.Controls.Add(this.chkIngles);
            this.Controls.Add(this.chkEspanol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEspanol;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.CheckBox chkFrances;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblSelecciona;
    }
}

