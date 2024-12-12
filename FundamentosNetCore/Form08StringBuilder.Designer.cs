namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(521, 40);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(52, 71);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(853, 214);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(52, 297);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(341, 40);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo del proceso";
            // 
            // btnString
            // 
            btnString.Location = new Point(52, 357);
            btnString.Name = "btnString";
            btnString.Size = new Size(365, 90);
            btnString.TabIndex = 3;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(536, 357);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(369, 90);
            btnBuilder.TabIndex = 4;
            btnBuilder.Text = "Invertir con StringBuilder";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(18F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 513);
            Controls.Add(btnBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnString;
        private Button btnBuilder;
    }
}