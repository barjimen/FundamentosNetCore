namespace FundamentosNetCore
{
    partial class Form07SumarNumerosString
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
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 18);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(48, 54);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(229, 39);
            txtNumeros.TabIndex = 1;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(50, 108);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(227, 55);
            btnSumarNumeros.TabIndex = 2;
            btnSumarNumeros.Text = "Sumar números";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(51, 178);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form07SumarNumerosString
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 240);
            Controls.Add(lblResultado);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form07SumarNumerosString";
            Text = "Form07SumarNumerosString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}