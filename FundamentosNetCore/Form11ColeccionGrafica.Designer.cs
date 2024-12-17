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
            label1 = new Label();
            lstElementos = new ListBox();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(33, 56);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(247, 292);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 17);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 2;
            label2.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(346, 52);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(275, 39);
            txtNuevoElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(349, 109);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(212, 59);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(354, 184);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(207, 61);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(354, 259);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(207, 73);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(33, 360);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(229, 32);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(33, 408);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(239, 32);
            lblIndexSeleccionado.TabIndex = 8;
            lblIndexSeleccionado.Text = "lblIndexSeleccionado";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 466);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
    }
}