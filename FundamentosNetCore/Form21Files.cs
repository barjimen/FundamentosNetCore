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
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        public Form21Files()
        {
            InitializeComponent();
            this.Path = "prueba.txt";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.lstNombre.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
        }
        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombre.Items)
            {
                data += name + ",";
            }
            return data;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            TextWriter writer = file.CreateText();
            string contenido = this.GetNombresListBox();
            writer.Write(contenido);
            writer.Flush();
            writer.Close();
        }
    }
}
