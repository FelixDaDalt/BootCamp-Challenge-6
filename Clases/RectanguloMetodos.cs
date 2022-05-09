using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases
{
    partial class Rectangulo
    {
        public double RetornarSuperficie()
        {
            double super = this.lado1 + this.lado2;
            return super;
        }
    }
}
