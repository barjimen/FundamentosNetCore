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
    public partial class Form10ValidarDNI : Form
    {
        public Form10ValidarDNI()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = this.txtDni.Text;
            char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E', 'T' };
            int lenght = this.txtDni.TextLength;
            if (lenght == 9)
            {
                string numeros = dni.Substring(0, 8);
                int numero = int.Parse(numeros);
                string letra = dni.Substring(8);
                int resultado = (numero - (numero / 23) * 23);
                if (letra == letras[resultado].ToString())
                    this.lblValidado.Text = "DNI válido";
                else
                    this.lblValidado.Text = "DNI Inválido, su letra es: " + letras[resultado].ToString();
            }
            else
                this.lblValidado.Text = "Necesitas 9 caracteres.";
        }
    }
}
