using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_6.Clases;
using BootCamp_Challenge_6.Clases2;

namespace BootCamp_Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            Console.ReadKey();

        }

        static void Ejercicio1()
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Lado1 = 2.5;
            rectangulo.Lado2 = 3.5;
            Console.WriteLine(rectangulo.RetornarSuperficie());

            Rectangulo rectangulo2 = new Rectangulo(2.5, 6.5);
            Console.WriteLine(rectangulo2.RetornarSuperficie());

          
        }

        static void Ejercicio2()
        {
            Vehiculo auto = new Vehiculo("falcon","bueno",120.5);
            auto.arrancar();
            auto.acelerar();
            auto.frenar();
            auto.apagar();
        }
    }
}
