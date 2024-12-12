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
                else if (cadena.StartsWith("@") || cadena.EndsWith("@"))
                    this.lblResultado.Text = "No se puede poner @ nu al principio ni al final";
                else if (!cadena.Contains("."))
                    this.lblResultado.Text = "Necesitas un punto";
                else if (!(cadena.IndexOf("@") < cadena.IndexOf(".")))
                    this.lblResultado.Text = "Neceistas . despues de @";
                else
                    this.lblResultado.Text = "Email válido";
            }
        }
    }
}
