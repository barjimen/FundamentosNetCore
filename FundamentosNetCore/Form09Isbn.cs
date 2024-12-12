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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadena = txtNumb.Text;
            int lenght = this.txtNumb.Text.Length;
            int suma = 0;
            if (lenght == 10)
            {
                for (int i = 0; i < lenght; i++)
                {
                    char numero = cadena[i];
                    int numeros = int.Parse(numero.ToString());
                    suma += numeros * (i + 1);
                }
                if (suma % 11 == 0)
                    this.lblValido.Text = "El ISBN es válido";
                else
                    this.lblValido.Text = "El ISBN es inválido";
            }
            else
                this.lblValido.Text = "El numero debe tener 10 caracteres.";
        }
    }
}
