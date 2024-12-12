namespace FundamentosNetCore
{
    partial class Form10ValidarDNI
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
            txtDni = new TextBox();
            lblValidado = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 0;
            label1.Text = "Validar DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(66, 81);
            txtDni.Margin = new Padding(6, 4, 6, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(246, 34);
            txtDni.TabIndex = 1;
            // 
            // lblValidado
            // 
            lblValidado.AutoSize = true;
            lblValidado.Location = new Point(66, 195);
            lblValidado.Margin = new Padding(6, 0, 6, 0);
            lblValidado.Name = "lblValidado";
            lblValidado.Size = new Size(90, 26);
            lblValidado.TabIndex = 2;
            lblValidado.Text = "label2";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(66, 135);
            btnValidar.Margin = new Padding(6, 4, 6, 4);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(246, 38);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form10ValidarDNI
            // 
            AutoScaleDimensions = new SizeF(16F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 295);
            Controls.Add(btnValidar);
            Controls.Add(lblValidado);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Font = new Font("Broadway", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form10ValidarDNI";
            Text = "Form10ValidarDNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Label lblValidado;
        private Button btnValidar;
    }
}