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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevo.Text;
            this.lstElementos.Items.Add(elemento);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string elementoSeleccionado = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(elementoSeleccionado);
            //Para apartados gráficos.
            int indexSeleccionado = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indexSeleccionado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndexSeleccionado.Text = "Index seleccionado: " + this.lstElementos.SelectedIndex;
                this.lblItemSeleccionado.Text = "Item seleccionado: " + this.lstElementos.SelectedItem;
            }
        }
    }
}
