namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            lblResultado = new Label();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            label3 = new Label();
            txtSoloLetras = new TextBox();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(25, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(228, 39);
            txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(22, 163);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(203, 82);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(28, 113);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(24, 265);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(201, 81);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(28, 368);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(197, 100);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 18);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 6;
            label2.Text = "Sólo números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(345, 54);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(354, 39);
            txtSoloNumeros.TabIndex = 7;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 114);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 8;
            label3.Text = "Sólo letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(350, 146);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(349, 39);
            txtSoloLetras.TabIndex = 9;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(128, 255, 128);
            lblRaton.BorderStyle = BorderStyle.FixedSingle;
            lblRaton.Location = new Point(352, 217);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(461, 229);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 480);
            Controls.Add(lblRaton);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(lblResultado);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            FormClosed += Form15Metodos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Label lblResultado;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label2;
        private TextBox txtSoloNumeros;
        private Label label3;
        private TextBox txtSoloLetras;
        private Label lblRaton;
    }
}