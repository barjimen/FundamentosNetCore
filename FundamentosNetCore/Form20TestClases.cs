using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Apellidos";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Femenino;
            persona.Nacionalidad = Paises.Italia;
            persona.Domicilio.Calle = "Oficina de Correos";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28938;

            this.lstClases.Items.Add(" ");
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("Empleado1", "ApellidoEmpleado1");
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";
            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("salario Empleado ");
            this.lstClases.Items.Add("Vacaciones: " + empleado.GetDiasVacaciones());

            Director dire = new Director();
            dire.Nombre = "Director";
            dire.Apellidos = "Director";
            this.lstClases.Items.Add(dire.GetNombreCompleto());
            this.lstClases.Items.Add("salario Dire ");
            this.lstClases.Items.Add("Vacaciones: " + dire.GetDiasVacaciones());
        }
    }
}
