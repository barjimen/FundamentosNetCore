namespace FundamentosNetCore
{
    partial class Form09ValidarISBN
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
            txtIsbn = new TextBox();
            btnValidarIsbn = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(29, 61);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(313, 39);
            txtIsbn.TabIndex = 1;
            txtIsbn.Text = "8441513929";
            txtIsbn.TextAlign = HorizontalAlignment.Center;
            // 
            // btnValidarIsbn
            // 
            btnValidarIsbn.Location = new Point(30, 117);
            btnValidarIsbn.Name = "btnValidarIsbn";
            btnValidarIsbn.Size = new Size(312, 51);
            btnValidarIsbn.TabIndex = 2;
            btnValidarIsbn.Text = "Validar ISBN";
            btnValidarIsbn.UseVisualStyleBackColor = true;
            btnValidarIsbn.Click += btnValidarIsbn_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(31, 186);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form09ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 239);
            Controls.Add(lblResultado);
            Controls.Add(btnValidarIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form09ValidarISBN";
            Text = "Form09ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnValidarIsbn;
        private Label lblResultado;
    }
}