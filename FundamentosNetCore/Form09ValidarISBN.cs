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
    public partial class Form09ValidarISBN : Form
    {
        public Form09ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidarIsbn_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                this.lblResultado.Text = "El ISBN debe ser de 10 caracteres";
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN correcto";
                    this.lblResultado.ForeColor = Color.Blue;
                }
                else
                {
                    this.lblResultado.Text = "ISBN incorrecto";
                    this.lblResultado.ForeColor = Color.Red;
                }
            }
        }
    }
}
