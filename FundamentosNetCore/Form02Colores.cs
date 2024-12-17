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
    public partial class Form02Colores : Form
    {
        public Form02Colores()
        {
            InitializeComponent();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show
                    ("El valor rojo debe estar entre 0 y 255"
                    ,"Titulo", MessageBoxButtons.RetryCancel
                    , MessageBoxIcon.Question);
            }else if (verde < 0 || verde > 255)
            {
                MessageBox.Show
                    ("El valor verde debe estar entre 0 y 255"
                    , "Titulo", MessageBoxButtons.RetryCancel
                    , MessageBoxIcon.Question);
            }else if (azul < 0 || azul > 255)
            {
                MessageBox.Show
                    ("El valor azul debe estar entre 0 y 255"
                    , "Titulo", MessageBoxButtons.RetryCancel
                    , MessageBoxIcon.Question);
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
           
        }
    }
}
