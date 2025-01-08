using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino}
    public enum Paises { España, Francia, Italia, Alemania}
    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor Persona sin parámetros");
        }
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor Persona con 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #region Propiedades
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set { 
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripcion: " + aleat;
            }
        }
        public Direcciones Domicilio { get; set; }
        public Direcciones DomicilioVacaciones { get; set; }





        public TipoGenero Genero { get; set; }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        private int _Edad;
        private TipoGenero _Genero;
        public TipoGenero Genro
        {
            get { return _Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                    throw new Exception("Valor incorrecto");
                else
                    this._Genero = value;
            }
        }

        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //Aquí comprobamos el valor
                if (value < 0)
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
        #endregion
        #region Metodos
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompletoDelReves()
        {
            return this.Apellidos + " " + this.Nombre;
        }
        
        public string GetNombreMayus()
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreMinus()
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }
        #endregion



    }
}
