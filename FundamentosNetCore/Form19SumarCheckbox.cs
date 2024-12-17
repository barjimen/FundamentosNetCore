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
    public partial class Form19SumarCheckbox : Form
    {
        List<CheckBox> checkList;
        int suma;
        public Form19SumarCheckbox()
        {
            InitializeComponent();
            this.checkList = new List<CheckBox>();
            this.suma = 0;

            foreach (CheckBox check in this.panel1.Controls)
            {
                this.checkList.Add(check);
                if (check.Checked )
                    check.Text += SumarCheck;
            }
        }

        void SumarCheck(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int numero = int.Parse(checkBox.Text);
            this.suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();
            foreach (CheckBox checkBox in this.checkList)
            {
                int nbAleatorio = random.Next(1,99);
                checkBox.Text = nbAleatorio.ToString();
            }
        }
    }
}
