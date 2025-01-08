using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor Director");
        }
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("Método Vacaciones Director");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 10;
            //return 30;
        }
        public int GetDiasVacas()
        {
            return this.GetDiasVacaciones();
        }
    }
}
