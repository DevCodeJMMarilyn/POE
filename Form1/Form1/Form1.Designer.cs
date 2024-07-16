namespace Form1
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
            this.calcularbutton = new System.Windows.Forms.Button();
            this.text_keydown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularbutton
            // 
            this.calcularbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.calcularbutton.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcularbutton.Location = new System.Drawing.Point(188, 90);
            this.calcularbutton.Name = "calcularbutton";
            this.calcularbutton.Size = new System.Drawing.Size(428, 142);
            this.calcularbutton.TabIndex = 0;
            this.calcularbutton.Text = "don\'t push";
            this.calcularbutton.UseVisualStyleBackColor = false;
            this.calcularbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_keydown
            // 
            this.text_keydown.AccessibleName = "text_Keydown";
            this.text_keydown.AutoSize = true;
            this.text_keydown.Location = new System.Drawing.Point(391, 38);
            this.text_keydown.Name = "text_keydown";
            this.text_keydown.Size = new System.Drawing.Size(35, 13);
            this.text_keydown.TabIndex = 1;
            this.text_keydown.Text = "label1";
            this.text_keydown.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_keydown);
            this.Controls.Add(this.calcularbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularbutton;
        private System.Windows.Forms.Label text_keydown;
    }
}

