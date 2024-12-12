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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string cadena = txtMail.Text;
            if (cadena.Length == 0 || cadena.Length == 1)
                this.lblResultado.Text = "Email no valido";
            if (cadena.Length > 1)
            {
                if (!cadena.Contains("@"))
                    this.lblResultado.Text = "No hay @ en la cedana";
                else if (cadena.IndexOf("@") == 0 || cadena.EndsWith("@"))
                    this.lblResultado.Text = "No se puede poner @ nu al principio ni al final";
                else if (!cadena.Contains("."))
                    this.lblResultado.Text = "Necesitas un punto";
                else if (cadena.LastIndexOf(".") < cadena.IndexOf("@"))
                    this.lblResultado.Text = "Neceistas . despues de @";
                else
                {
                    int ultimoPunti = cadena.LastIndexOf('.');
                    string dominio = cadena.Substring(ultimoPunti + 1);
                    if(dominio.Length >= 2 && dominio.Length <= 4)
                        this.lblResultado.Text = "Email válido";
                    else
                        this.lblResultado.Text = "Email Inválido";
                }
                
            }
        }
    }
}
