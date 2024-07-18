namespace calcular
{
    partial class Calcu
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
            this.Calculadora = new System.Windows.Forms.Label();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.CalcularSumButtom = new System.Windows.Forms.Button();
            this.twoNumberLabel = new System.Windows.Forms.Label();
            this.firstNumberTextbox = new System.Windows.Forms.TextBox();
            this.twoNumberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculadora
            // 
            this.Calculadora.AccessibleName = "calculadora";
            this.Calculadora.AutoSize = true;
            this.Calculadora.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.Location = new System.Drawing.Point(436, 47);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(206, 42);
            this.Calculadora.TabIndex = 0;
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLabel.Location = new System.Drawing.Point(400, 125);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(149, 24);
            this.firstNumberLabel.TabIndex = 1;
            this.firstNumberLabel.Text = "Primer numero";
            this.firstNumberLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CalcularSumButtom
            // 
            this.CalcularSumButtom.Location = new System.Drawing.Point(387, 362);
            this.CalcularSumButtom.Name = "CalcularSumButtom";
            this.CalcularSumButtom.Size = new System.Drawing.Size(75, 23);
            this.CalcularSumButtom.TabIndex = 2;
            this.CalcularSumButtom.Text = "Sumar";
            this.CalcularSumButtom.UseVisualStyleBackColor = true;
            this.CalcularSumButtom.Click += new System.EventHandler(this.calcular_Click);
            // 
            // twoNumberLabel
            // 
            this.twoNumberLabel.AutoSize = true;
            this.twoNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoNumberLabel.Location = new System.Drawing.Point(400, 163);
            this.twoNumberLabel.Name = "twoNumberLabel";
            this.twoNumberLabel.Size = new System.Drawing.Size(173, 24);
            this.twoNumberLabel.TabIndex = 3;
            this.twoNumberLabel.Text = "Segundo numero";
            // 
            // firstNumberTextbox
            // 
            this.firstNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberTextbox.Location = new System.Drawing.Point(579, 120);
            this.firstNumberTextbox.Name = "firstNumberTextbox";
            this.firstNumberTextbox.Size = new System.Drawing.Size(100, 29);
            this.firstNumberTextbox.TabIndex = 4;
            // 
            // twoNumberTextbox
            // 
            this.twoNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoNumberTextbox.Location = new System.Drawing.Point(579, 163);
            this.twoNumberTextbox.Name = "twoNumberTextbox";
            this.twoNumberTextbox.Size = new System.Drawing.Size(100, 29);
            this.twoNumberTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Respuesta =";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(484, 266);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(394, 29);
            this.resultLabel.TabIndex = 7;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(387, 510);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 8;
            this.btnD.Text = "Dividir";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(387, 411);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 9;
            this.btnR.Text = "Restar";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnm
            // 
            this.btnm.Location = new System.Drawing.Point(387, 458);
            this.btnm.Name = "btnm";
            this.btnm.Size = new System.Drawing.Size(75, 23);
            this.btnm.TabIndex = 10;
            this.btnm.Text = "Multiplicar";
            this.btnm.UseVisualStyleBackColor = true;
            this.btnm.Click += new System.EventHandler(this.btnm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(629, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Calcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 624);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnm);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.twoNumberTextbox);
            this.Controls.Add(this.firstNumberTextbox);
            this.Controls.Add(this.twoNumberLabel);
            this.Controls.Add(this.CalcularSumButtom);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.Calculadora);
            this.Name = "Calcu";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculadora;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Button CalcularSumButtom;
        private System.Windows.Forms.Label twoNumberLabel;
        private System.Windows.Forms.TextBox firstNumberTextbox;
        private System.Windows.Forms.TextBox twoNumberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnm;
        private System.Windows.Forms.Button btnReset;
    }
}

