using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
