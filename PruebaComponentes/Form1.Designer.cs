namespace PruebaComponentes
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
            this.btnCambiarPosicion = new System.Windows.Forms.Button();
            this.labelTextBox1 = new ApuntesT5.LabelTextBox();
            this.SuspendLayout();
            // 
            // btnCambiarPosicion
            // 
            this.btnCambiarPosicion.Location = new System.Drawing.Point(84, 128);
            this.btnCambiarPosicion.Name = "btnCambiarPosicion";
            this.btnCambiarPosicion.Size = new System.Drawing.Size(103, 58);
            this.btnCambiarPosicion.TabIndex = 1;
            this.btnCambiarPosicion.Text = "Cambiar posición de los elementos";
            this.btnCambiarPosicion.UseVisualStyleBackColor = true;
            this.btnCambiarPosicion.Click += new System.EventHandler(this.btnCambiarPosicion_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.labelTextBox1.Location = new System.Drawing.Point(104, 69);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = ApuntesT5.ePosicion.DERECHA;
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(83, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "Label";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.CambiaPosicion += new System.EventHandler(this.labelTextBox1_CambiaPosicion);
            this.labelTextBox1.CambiaSeparacion += new System.EventHandler(this.labelTextBox1_CambiaSeparacion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 262);
            this.Controls.Add(this.btnCambiarPosicion);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ApuntesT5.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btnCambiarPosicion;
    }
}

