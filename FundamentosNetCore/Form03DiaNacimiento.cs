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
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo--;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            if (resultado == 0)
            {
                this.lblDiaSemana.Text = "SABADO";
            }else if (resultado == 1)
            {
                this.lblDiaSemana.Text = "DOMINGO";
            }else if (resultado == 2)
            {
                this.lblDiaSemana.Text = "LUNES";
            }else if (resultado == 3)
            {
                this.lblDiaSemana.Text = "MARTES";
            }else if (resultado == 4)
            {
                this.lblDiaSemana.Text = "MIERCOLES";
            }else if (resultado == 5)
            {
                this.lblDiaSemana.Text = "JUEVES";
            }else if (resultado == 6)
            {
                this.lblDiaSemana.Text = "VIERNES";
            }else
            {
                this.lblDiaSemana.Text = "Algo ha ido muy mal";
            }

        }
    }
}
