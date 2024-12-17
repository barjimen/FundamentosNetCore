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
    public partial class Form15Metodos : Form
    {
        public Form15Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN NUMERO WRAPPER POR VALOR
        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        void Cambiarcolor(Button boton)
        {
            boton.BackColor = Color.LightGreen;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.Cambiarcolor(this.btnDobleReferencia);
            this.Cambiarcolor(this.btnDobleValor);
        }

        void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        int GetDoble(int num)
        {
            return num * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            numero = this.GetDoble(numero);
            //LAS DOS VARIABLES APUNTAN AL MISMO ESPACIO 
            //DE MEMORIA
            //this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = numero.ToString();
        }

        private void Form15Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //COMO NO PODEMOS ELIMINAR, DEBEMOS TAMBIEN ADMITIR
            //LA TECLA SE BORRAR (TENEMOS UN CHAR), DEBEMOS SABER
            // QUE TECLA TRADUCIDA A CHAR CORRESPONDE CON LA DE BORRAR
            //EXISTE UNA ENUMERACION LLAMADA Keys QUE NOS OFRECE LOS 
            //CODIGOS ASCII DE TODAS LAS TECLAS
            char teclaBorrar = (char)Keys.Back;

            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
