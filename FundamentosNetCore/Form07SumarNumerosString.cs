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
    public partial class Form07SumarNumerosString : Form
    {
        public Form07SumarNumerosString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtSumar.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];
                int numb = int.Parse(caracter.ToString());
                suma += numb;
            }
            this.lblResultado.Text = suma.ToString();
        }
    }
}
