namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrarTodos = new Button();
            label2 = new Label();
            lstTienda = new ListBox();
            btnSeleccionados = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(24, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(203, 39);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(26, 111);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(201, 45);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(30, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.Location = new Point(30, 224);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(197, 54);
            btnBorrarTodos.TabIndex = 4;
            btnBorrarTodos.Text = "Borrar todo";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += btnBorrarTodos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 10);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(255, 45);
            lstTienda.Name = "lstTienda";
            lstTienda.SelectionMode = SelectionMode.MultiExtended;
            lstTienda.Size = new Size(226, 292);
            lstTienda.TabIndex = 6;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccionados.Location = new Point(487, 94);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(114, 46);
            btnSeleccionados.TabIndex = 7;
            btnSeleccionados.Text = "Selección";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(496, 168);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(98, 57);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(600, 45);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(226, 292);
            lstAlmacen.TabIndex = 10;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 10);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 9;
            label3.Text = "Almacén";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(844, 94);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(90, 46);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(848, 151);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(86, 51);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 363);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionados);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodos);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrarTodos;
        private Label label2;
        private ListBox lstTienda;
        private Button btnSeleccionados;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btnSubir;
        private Button btnBajar;
    }
}