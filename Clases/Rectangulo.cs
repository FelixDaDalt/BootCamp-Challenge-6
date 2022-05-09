using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases
{
    partial class Rectangulo
    {
        private double lado1;
        private double lado2;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public Rectangulo()
        {

        }

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }


    }
}
