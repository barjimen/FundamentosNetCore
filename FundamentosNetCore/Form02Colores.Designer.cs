namespace FundamentosNetCore
{
    partial class Form02Colores
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
            txtRojo = new TextBox();
            label2 = new Label();
            txtVerde = new TextBox();
            label3 = new Label();
            txtAzul = new TextBox();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 0;
            label1.Text = "Rojo";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(33, 53);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 39);
            txtRojo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 109);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 2;
            label2.Text = "Verde";
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(33, 146);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 39);
            txtVerde.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 203);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 4;
            label3.Text = "Azul";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(37, 242);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 39);
            txtAzul.TabIndex = 5;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(215, 87);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(186, 77);
            btnCambiarColor.TabIndex = 6;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // Form02Colores
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 307);
            Controls.Add(btnCambiarColor);
            Controls.Add(txtAzul);
            Controls.Add(label3);
            Controls.Add(txtVerde);
            Controls.Add(label2);
            Controls.Add(txtRojo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form02Colores";
            Text = "Form02Colores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRojo;
        private Label label2;
        private TextBox txtVerde;
        private Label label3;
        private TextBox txtAzul;
        private Button btnCambiarColor;
    }
}