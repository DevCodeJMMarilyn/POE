namespace Practica2POE.Encapsulamiento.Modulo
{
    partial class EncapsulamientoF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RealizarDeposito = new System.Windows.Forms.Button();
            this.RealizarRetiro = new System.Windows.Forms.Button();
            this.VerSaldo = new System.Windows.Forms.Button();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el monto a retirar o depositar";
            // 
            // RealizarDeposito
            // 
            this.RealizarDeposito.Location = new System.Drawing.Point(87, 190);
            this.RealizarDeposito.Name = "RealizarDeposito";
            this.RealizarDeposito.Size = new System.Drawing.Size(75, 23);
            this.RealizarDeposito.TabIndex = 1;
            this.RealizarDeposito.Text = "Depositar";
            this.RealizarDeposito.UseVisualStyleBackColor = true;
            this.RealizarDeposito.Click += new System.EventHandler(this.RealizarDeposito_Click);
            // 
            // RealizarRetiro
            // 
            this.RealizarRetiro.Location = new System.Drawing.Point(225, 190);
            this.RealizarRetiro.Name = "RealizarRetiro";
            this.RealizarRetiro.Size = new System.Drawing.Size(75, 23);
            this.RealizarRetiro.TabIndex = 2;
            this.RealizarRetiro.Text = "Retirar";
            this.RealizarRetiro.UseVisualStyleBackColor = true;
            this.RealizarRetiro.Click += new System.EventHandler(this.RealizarRetiro_Click);
            // 
            // VerSaldo
            // 
            this.VerSaldo.Location = new System.Drawing.Point(345, 190);
            this.VerSaldo.Name = "VerSaldo";
            this.VerSaldo.Size = new System.Drawing.Size(75, 23);
            this.VerSaldo.TabIndex = 3;
            this.VerSaldo.Text = "Saldo";
            this.VerSaldo.UseVisualStyleBackColor = true;
            this.VerSaldo.Click += new System.EventHandler(this.VerSaldo_Click);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(178, 103);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(177, 20);
            this.MontoTextBox.TabIndex = 4;
            // 
            // EncapsulamientoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 300);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.VerSaldo);
            this.Controls.Add(this.RealizarRetiro);
            this.Controls.Add(this.RealizarDeposito);
            this.Controls.Add(this.label1);
            this.Name = "EncapsulamientoF";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RealizarDeposito;
        private System.Windows.Forms.Button RealizarRetiro;
        private System.Windows.Forms.Button VerSaldo;
        private System.Windows.Forms.TextBox MontoTextBox;
    }
}