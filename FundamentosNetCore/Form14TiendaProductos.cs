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
    public partial class Form14TiendaProductos : Form
    {



        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode =
                 SelectionMode.MultiExtended;
        }
           
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text.ToUpper();
            int index = this.lstTienda.Items.IndexOf(producto);
            if (index == -1)
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.SelectAll();
                this.txtProducto.Focus();
            }
            else
            {
                this.lstTienda.SelectedIndex = index;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count;
            for (int i = numElementos - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodos_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //ELIMINAMOS DE LA TIENDA LOS SELECCIONADOS
            int numElementos = this.lstTienda.SelectedIndices.Count;
            for (int i = numElementos - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string producto = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //TENEMOS UN METODO LLAMADO AddRange EN LAS COLECCIONES
            //QUE PERMITEN AGREGAR UN CONJUNTO A LA VEZ
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
