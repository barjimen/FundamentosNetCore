using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int salarioMinimo { get; set; }//Para que set no pueda modificar el valor, podemos optar por varias opciones: 1.Private, 2.Protected

        public Empleado()
        {
            Debug.WriteLine("Mensajito desde Empleado");
            this.salarioMinimo = 1000;
        }
        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)//Base sirve para forzar la herencia
        {
            Debug.WriteLine("Constructor Empleado con 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            salarioMinimo = 1000;
        }
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("Método Vacaciones");
            return 22;
        }
    }
}
