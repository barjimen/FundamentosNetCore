namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            txtDia = new TextBox();
            label2 = new Label();
            txtMes = new TextBox();
            Lablel33 = new Label();
            txtAnyo = new TextBox();
            btnCalcularDiaNacimiento = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(38, 53);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 39);
            txtDia.TabIndex = 1;
            txtDia.Text = "15";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(38, 141);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 39);
            txtMes.TabIndex = 3;
            txtMes.Text = "6";
            // 
            // Lablel33
            // 
            Lablel33.AutoSize = true;
            Lablel33.Location = new Point(32, 188);
            Lablel33.Name = "Lablel33";
            Lablel33.Size = new Size(57, 32);
            Lablel33.TabIndex = 4;
            Lablel33.Text = "Año";
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(32, 224);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 39);
            txtAnyo.TabIndex = 5;
            txtAnyo.Text = "1997";
            // 
            // btnCalcularDiaNacimiento
            // 
            btnCalcularDiaNacimiento.Location = new Point(210, 20);
            btnCalcularDiaNacimiento.Name = "btnCalcularDiaNacimiento";
            btnCalcularDiaNacimiento.Size = new Size(231, 125);
            btnCalcularDiaNacimiento.TabIndex = 6;
            btnCalcularDiaNacimiento.Text = "Calcular día nacimiento";
            btnCalcularDiaNacimiento.UseVisualStyleBackColor = true;
            btnCalcularDiaNacimiento.Click += btnCalcularDiaNacimiento_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(254, 190);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(160, 32);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 275);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDiaNacimiento);
            Controls.Add(txtAnyo);
            Controls.Add(Lablel33);
            Controls.Add(txtMes);
            Controls.Add(label2);
            Controls.Add(txtDia);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDia;
        private Label label2;
        private TextBox txtMes;
        private Label Lablel33;
        private TextBox txtAnyo;
        private Button btnCalcularDiaNacimiento;
        private Label lblDiaSemana;
    }
}