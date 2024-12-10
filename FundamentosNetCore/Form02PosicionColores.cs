using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnPosicion = new Button();
            btnCambiarColor = new Button();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            txtRed = new TextBox();
            txtGreen = new TextBox();
            txtBlue = new TextBox();
            lblPosX = new Label();
            lblPosY = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(25, 187);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(194, 29);
            btnPosicion.TabIndex = 0;
            btnPosicion.Text = "Cambiar posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(532, 222);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(194, 29);
            btnCambiarColor.TabIndex = 1;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(25, 50);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(194, 27);
            txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(25, 121);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(194, 27);
            txtPosY.TabIndex = 3;
            // 
            // txtRed
            // 
            txtRed.Location = new Point(532, 38);
            txtRed.Name = "txtRed";
            txtRed.Size = new Size(194, 27);
            txtRed.TabIndex = 4;
            // 
            // txtGreen
            // 
            txtGreen.Location = new Point(532, 104);
            txtGreen.Name = "txtGreen";
            txtGreen.Size = new Size(194, 27);
            txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(532, 165);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(194, 27);
            txtBlue.TabIndex = 6;
            // 
            // lblPosX
            // 
            lblPosX.AutoSize = true;
            lblPosX.Location = new Point(25, 27);
            lblPosX.Name = "lblPosX";
            lblPosX.Size = new Size(79, 20);
            lblPosX.TabIndex = 7;
            lblPosX.Text = "Posicion X:";
            // 
            // lblPosY
            // 
            lblPosY.AutoSize = true;
            lblPosY.Location = new Point(25, 98);
            lblPosY.Name = "lblPosY";
            lblPosY.Size = new Size(78, 20);
            lblPosY.TabIndex = 8;
            lblPosY.Text = "Posicion Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 9;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 10;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 142);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 11;
            label3.Text = "Azul";
            // 
            // Form02PosicionColores
            // 
            ClientSize = new Size(827, 276);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPosY);
            Controls.Add(lblPosX);
            Controls.Add(txtBlue);
            Controls.Add(txtGreen);
            Controls.Add(txtRed);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(btnCambiarColor);
            Controls.Add(btnPosicion);
            Name = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int y = int.Parse(txtPosY.Text);
            int x = int.Parse(txtPosX.Text);
            this.btnPosicion.Location = new Point(x, y);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtRed.Text);
            int verde = int.Parse(txtGreen.Text);
            int azul = int.Parse(txtBlue.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
