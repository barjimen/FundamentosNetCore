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
    public partial class Form17ListDelegados : Form
    {
        int contador;
        List<Button> buttonList;
        //Los objtos se inicializan siempre en el constructor.
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.buttonList = new List<Button>();
            //this.button1.Click += BotonPulsado;

            //this.buttonList.Add(this.button1);
            //this.buttonList.Add(this.button2);
            //this.buttonList.Add(this.button3);

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    this.buttonList.Add((Button)control);
                }

                foreach (Button button in this.buttonList)
                {
                    button.Click += BotonPulsado;
                }
            }

            void BotonPulsado(object sender, EventArgs e)
            {
                this.contador += 1;
                this.txtContador.Text = this.contador.ToString();
                Button miBoton = (Button)sender;
                miBoton.BackColor = Color.Pink;
            }
        }
    }
}
