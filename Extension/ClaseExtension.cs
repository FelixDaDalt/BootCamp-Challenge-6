using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_6.Clases3;

namespace BootCamp_Challenge_6.Extension
{
    static class ClaseExtension
    {
        public static string primeraMidad(this string tex)
        {
            return tex.Substring(0, tex.Length / 2);
        }
        public static string segundaMidad(this string tex)
        {
            return tex.Substring(tex.Length / 2);
        }
        public static bool mayorEdad(this Persona p)
        {
            if (DateTime.Today.AddTicks(-p.FecNacimiento.Ticks).Year - 1 > 18)
                return true;
            else
                return false;
        }
    }
}
