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
            label1 = new Label();
            txtNumeros = new TextBox();
            txtLetras = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(49, 56);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(317, 129);
            txtNumeros.TabIndex = 1;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(471, 56);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(317, 129);
            txtLetras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 20);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 2;
            label2.Text = "Letras";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(49, 232);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(317, 129);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 196);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(471, 232);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(317, 129);
            txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 196);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(345, 381);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(138, 54);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 469);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnRun;
    }
}