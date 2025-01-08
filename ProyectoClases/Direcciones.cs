using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direcciones
    {
        public string Calle {  get; set; }
        public string Ciudad {  get; set; }
        public int CodigoPostal { get; set; }

        public Direcciones() 
        {
            Debug.WriteLine("Constructor Direccion sin parámetros");
        }

        public Direcciones(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion con dos parametros");
        }

        public Direcciones(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor de todo");
        }
    }
}
