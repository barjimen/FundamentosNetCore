namespace FundamentosNetCore
{
    partial class Form21Files
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
            label2 = new Label();
            txtNombre = new TextBox();
            btnNew = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            label3 = new Label();
            lstNombre = new ListBox();
            lstFiles = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 26);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(336, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(336, 96);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(159, 29);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo nombre";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(336, 147);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(159, 29);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = false;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(336, 194);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(159, 29);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 26);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // lstNombre
            // 
            lstNombre.FormattingEnabled = true;
            lstNombre.Location = new Point(578, 49);
            lstNombre.Name = "lstNombre";
            lstNombre.Size = new Size(210, 344);
            lstNombre.TabIndex = 9;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(41, 49);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(230, 344);
            lstFiles.TabIndex = 10;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstFiles);
            Controls.Add(lstNombre);
            Controls.Add(label3);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNew;
        private Button btnRead;
        private Button btnWrite;
        private Label label3;
        private ListBox lstNombre;
        private ListBox lstFiles;
    }
}