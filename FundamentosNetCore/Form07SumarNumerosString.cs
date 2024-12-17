using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FundamentosNetCore
{
    public partial class Form07SumarNumerosString : Form
    {
        public Form07SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                //RECUPERAMOS CADA UNO DE LOS CARACTERES
                char caracter = textoNumeros[i];
                //CONVERTIMOS EL CARACTER A NUMERO
                //CON ESTA CONVERSION ESTA RECUPERANDO EL VALOR
                //ASCII DEL NUMERO
                //int numero = caracter;
                //int numero = int.Parse(caracter.ToString());
                int numero = Convert.ToInt32(caracter.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma es " + suma;
        }
    }
}
