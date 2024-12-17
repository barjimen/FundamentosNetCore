namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            rdbAnyos = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(37, 56);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(518, 39);
            txtFechaActual.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(37, 116);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(278, 36);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(37, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 206);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(292, 132);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(210, 49);
            btnIncrementar.TabIndex = 5;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(324, 87);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(124, 39);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 54);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(38, 133);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(85, 36);
            rdbAnyos.TabIndex = 2;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(38, 91);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(100, 36);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(38, 49);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(77, 36);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 384);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 4;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(39, 427);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(516, 39);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 495);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private Label label2;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}