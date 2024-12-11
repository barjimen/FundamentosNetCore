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
            txtD = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            btnCalcularDiaNacimiento = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // txtD
            // 
            txtD.AutoSize = true;
            txtD.Location = new Point(33, 40);
            txtD.Name = "txtD";
            txtD.Size = new Size(32, 20);
            txtD.TabIndex = 0;
            txtD.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 127);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 200);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(33, 63);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(33, 150);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(33, 223);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(125, 27);
            txtAño.TabIndex = 5;
            // 
            // btnCalcularDiaNacimiento
            // 
            btnCalcularDiaNacimiento.Location = new Point(33, 286);
            btnCalcularDiaNacimiento.Name = "btnCalcularDiaNacimiento";
            btnCalcularDiaNacimiento.Size = new Size(125, 29);
            btnCalcularDiaNacimiento.TabIndex = 6;
            btnCalcularDiaNacimiento.Text = "button1";
            btnCalcularDiaNacimiento.UseVisualStyleBackColor = true;
            btnCalcularDiaNacimiento.Click += btnCalcularDiaNacimiento_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(250, 150);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(87, 20);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "Dia semana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDiaNacimiento);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtD);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtD;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Button btnCalcularDiaNacimiento;
        private Label lblDiaSemana;
    }
}