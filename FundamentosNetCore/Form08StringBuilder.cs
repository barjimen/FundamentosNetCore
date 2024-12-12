using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + " y Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            int longi = cadena.Length;
            krono.Start();
            for(int i = 0;i < longi; i++)
            {
                char letra = cadena[longi - 1];
                cadena = cadena.Remove((longi - 1), 1);
                cadena = cadena.Insert(i, letra);
            }
            krono.Stop();
            this.txtTexto.Text = cadena.ToString();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + " ,Milisegundos: " + krono.Elapsed.Milliseconds;
        }
    }
}
