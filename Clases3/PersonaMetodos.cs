using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases3
{
    partial class Persona
    {

        public void edad()
        {
          int edad= DateTime.Today.AddTicks(-this.fecNacimiento.Ticks).Year - 1;
            Console.WriteLine($"Edad: {edad} años");
        }

        public void getNombre()
        {
            
            Console.WriteLine($"Nombre: {this.nombre}");
        }
    }
}
