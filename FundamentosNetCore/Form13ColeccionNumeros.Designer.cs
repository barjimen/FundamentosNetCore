namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            label3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Items.AddRange(new object[] { "5", "2", "7", "3", "8", "4" });
            lstNumeros.Location = new Point(35, 44);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(205, 292);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(309, 21);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(212, 54);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(311, 91);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(210, 60);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 179);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(388, 172);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(122, 39);
            txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(388, 230);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(122, 39);
            txtPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 237);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(388, 296);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(122, 39);
            txtImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 303);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 379);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label label3;
        private TextBox txtImpares;
        private Label label4;
    }
}