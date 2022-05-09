using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases2
{
    partial class Vehiculo
    {
        public void frenar()
        {
            Console.WriteLine($"El vehiculo {this._nombre} Freno");
        }

        public void arrancar()
        {
            Console.WriteLine($"El vehiculo {this._nombre} Arranco");
        }

        public void acelerar()
        {
            Console.WriteLine($"El vehiculo {this._nombre} Acelero a {this._velocidad} km/h y su estado de motor es {this._estadoMotor}");
        }

        public void apagar()
        {
            Console.WriteLine($"El vehiculo {this._nombre} se apago");
        }

    }
}
