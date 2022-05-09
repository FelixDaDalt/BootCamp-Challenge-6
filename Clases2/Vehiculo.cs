using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases2
{
    partial class Vehiculo
    {
        private string _nombre;
        private string _estadoMotor;
        private double _velocidad;

        public string estadoMotor { get => _estadoMotor; set => _estadoMotor = value; }
        public double velocidad { get => _velocidad; set => _velocidad = value; }
        public string nombre { get => _nombre; set => _nombre = value; }

        public Vehiculo(string nombre, string estadomotor, double velocidad)
        {
            this._nombre = nombre;
            this._estadoMotor = estadomotor;
            this._velocidad = velocidad;
        }

        public Vehiculo()
        {

        }
    }
}
