using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases3
{
    partial class Persona
    {
        private string nombre;
        private DateTime fecNacimiento;

        public Persona(string nombre, DateTime fecNacimiento)
        {
            this.nombre = nombre;
            this.fecNacimiento = fecNacimiento;
        }
    }
}
