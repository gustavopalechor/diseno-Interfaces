namespace ComboBox
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
            this.cbIdiomas = new System.Windows.Forms.ComboBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbIdiomas
            // 
            this.cbIdiomas.FormattingEnabled = true;
            this.cbIdiomas.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cbIdiomas.Location = new System.Drawing.Point(89, 29);
            this.cbIdiomas.Name = "cbIdiomas";
            this.cbIdiomas.Size = new System.Drawing.Size(121, 24);
            this.cbIdiomas.TabIndex = 0;
            this.cbIdiomas.Text = "Seleccione un idioma";
            this.cbIdiomas.SelectedIndexChanged += new System.EventHandler(this.cbIdiomas_SelectedIndexChanged);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(89, 84);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 22);
            this.txtIdioma.TabIndex = 1;
            // 
            // btnIdioma
            // 
            this.btnIdioma.Location = new System.Drawing.Point(268, 82);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnIdioma.TabIndex = 2;
            this.btnIdioma.Text = "Añadir un idioma";
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(178, 157);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(46, 17);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "label1";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(283, 157);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(46, 17);
            this.lblIdioma.TabIndex = 4;
            this.lblIdioma.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnIdioma);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.cbIdiomas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIdiomas;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Button btnIdioma;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblIdioma;
    }
}

