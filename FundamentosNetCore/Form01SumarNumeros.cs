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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }
        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            int numb1 = int.Parse(txtNumero1.Text);
            int numb2 = int.Parse(txtNumero2.Text);
            int suma = numb1 + numb2;
            this.lblResultado.Text = suma.ToString();
        }
    }
}
