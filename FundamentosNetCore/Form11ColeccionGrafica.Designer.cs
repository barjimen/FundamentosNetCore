namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            txtNuevo = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(36, 82);
            lstElementos.Margin = new Padding(6);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(314, 204);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 42);
            label1.TabIndex = 1;
            label1.Text = "Elementos:";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(403, 82);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(388, 41);
            txtNuevo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 34);
            label2.Name = "label2";
            label2.Size = new Size(253, 42);
            label2.TabIndex = 3;
            label2.Text = "Nuevo Elemento";
            // 
            // button1
            // 
            button1.Location = new Point(403, 129);
            button1.Name = "button1";
            button1.Size = new Size(388, 50);
            button1.TabIndex = 4;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 190);
            button2.Name = "button2";
            button2.Size = new Size(388, 42);
            button2.TabIndex = 5;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(403, 243);
            button3.Name = "button3";
            button3.Size = new Size(388, 43);
            button3.TabIndex = 6;
            button3.Text = "Eliminar todo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(36, 292);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(104, 42);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "label3";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(36, 353);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(104, 42);
            lblIndexSeleccionado.TabIndex = 8;
            lblIndexSeleccionado.Text = "label3";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 452);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNuevo);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Font = new Font("Sitka Small", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private TextBox txtNuevo;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
    }
}