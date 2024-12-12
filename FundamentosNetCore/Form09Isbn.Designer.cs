namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            lblValido = new Label();
            btnValidar = new Button();
            txtNumb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 27);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // lblValido
            // 
            lblValido.AutoSize = true;
            lblValido.Location = new Point(40, 201);
            lblValido.Margin = new Padding(2, 0, 2, 0);
            lblValido.Name = "lblValido";
            lblValido.Size = new Size(232, 27);
            lblValido.TabIndex = 1;
            lblValido.Text = "¿Es válido?";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(40, 119);
            btnValidar.Margin = new Padding(2);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(500, 53);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtNumb
            // 
            txtNumb.Location = new Point(40, 69);
            txtNumb.Margin = new Padding(2);
            txtNumb.Name = "txtNumb";
            txtNumb.Size = new Size(500, 27);
            txtNumb.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(20F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 256);
            Controls.Add(txtNumb);
            Controls.Add(btnValidar);
            Controls.Add(lblValido);
            Controls.Add(label1);
            Font = new Font("Press Start 2P", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 4, 7, 4);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblValido;
        private Button btnValidar;
        private TextBox txtNumb;
    }
}