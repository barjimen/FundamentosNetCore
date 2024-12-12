namespace FundamentosNetCore
{
    partial class Form05Char
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
            txtSym = new TextBox();
            label3 = new Label();
            txtNumeros = new TextBox();
            label1 = new Label();
            txtLetras = new TextBox();
            label2 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // txtSym
            // 
            txtSym.Location = new Point(364, 43);
            txtSym.Multiline = true;
            txtSym.Name = "txtSym";
            txtSym.Size = new Size(125, 135);
            txtSym.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 20);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "simbolos";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(48, 43);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(125, 135);
            txtNumeros.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Numeros";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(211, 43);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(125, 135);
            txtLetras.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 20);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 10;
            label2.Text = "Letras";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(546, 43);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(125, 135);
            txtPuntuacion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 20);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 12;
            label4.Text = "puntuación";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(320, 235);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 14;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Controls.Add(txtSym);
            Controls.Add(label3);
            Name = "Form05Char";
            Text = "Fundamentos Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSym;
        private Label label3;
        private TextBox txtNumeros;
        private Label label1;
        private TextBox txtLetras;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnRun;
    }
}