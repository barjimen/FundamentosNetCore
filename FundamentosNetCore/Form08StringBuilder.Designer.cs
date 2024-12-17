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
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(303, 32);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(29, 54);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(630, 291);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(35, 407);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(224, 71);
            btnInvertirString.TabIndex = 2;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(395, 407);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(264, 71);
            btnInvertirStringBuilder.TabIndex = 3;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(30, 358);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(121, 32);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 490);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
        private Label lblTiempo;
    }
}