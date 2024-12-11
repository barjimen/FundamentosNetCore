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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDiaNacimiento_Click(object sender, EventArgs e)
        {

            int dia = int.Parse(txtDia.Text);
            int año = int.Parse(txtAño.Text);
            int mes = int.Parse(txtMes.Text);

            int ValorMes = ((mes + 1) * 3) / 5;
            int ValorAño1 = año / 4;
            int ValorAño2 = año / 100;
            int ValorAño3 = año / 400;
            int Suma1 = dia + (mes * 2) + año + ValorMes + ValorAño1 - ValorAño2 + ValorAño3 + 2;
            int DivSuma = Suma1 / 7;
            int Resultado = Suma1 - (DivSuma * 7);
            Array Dias = new string[] {"Sábado","Domingo", "Lunes","Martes" , "Miércoles", "Jueves", "Viernes"};
            this.lblDiaSemana.Text = Dias.GetValue(Resultado).ToString();

        }
    }
}
