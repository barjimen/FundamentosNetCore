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
        public Empleado():base("Nombre", "Apellidos")//Poner solo base o no es lo mismo, por eso se añade ("Nombre", "Apellidos")
        {
            Debug.WriteLine("Mensajito desde Empleado");
        }
        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)//Base sirve para forzar la herencia
        {
            Debug.WriteLine("Constructor Empleado con 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
