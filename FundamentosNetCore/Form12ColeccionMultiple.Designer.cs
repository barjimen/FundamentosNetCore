namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblIndexSeleccionados = new Label();
            lblItemsSeleccionados = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionados
            // 
            lblIndexSeleccionados.AutoSize = true;
            lblIndexSeleccionados.Location = new Point(37, 396);
            lblIndexSeleccionados.Name = "lblIndexSeleccionados";
            lblIndexSeleccionados.Size = new Size(249, 32);
            lblIndexSeleccionados.TabIndex = 17;
            lblIndexSeleccionados.Text = "lblIndexSeleccionados";
            // 
            // lblItemsSeleccionados
            // 
            lblItemsSeleccionados.AutoSize = true;
            lblItemsSeleccionados.Location = new Point(37, 348);
            lblItemsSeleccionados.Name = "lblItemsSeleccionados";
            lblItemsSeleccionados.Size = new Size(249, 32);
            lblItemsSeleccionados.TabIndex = 16;
            lblItemsSeleccionados.Text = "lblItemsSeleccionados";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(376, 263);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(207, 73);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(376, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(207, 61);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(371, 113);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(212, 59);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(368, 56);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(275, 39);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 21);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(37, 44);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(247, 292);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(378, 352);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(205, 60);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 437);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndexSeleccionados);
            Controls.Add(lblItemsSeleccionados);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionados;
        private Label lblItemsSeleccionados;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}