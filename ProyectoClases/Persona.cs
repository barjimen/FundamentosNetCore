using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Persona
    {
        public string Nombre;
        public string Apellidos;

        private int _Edad;

        public int Edad
        {
            get { return this._Edad; }
            set { 
            //Aquí comprobamos el valor
            if( value < 0 )
            {
                    //this._Edad = 0;
                    throw new Exception("La edad no puede ser negativa.");
            }
            else
            {
                    this._Edad = value;
            }
            }
        }
    }
}
