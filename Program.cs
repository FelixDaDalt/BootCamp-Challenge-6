using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_6.Clases;
using BootCamp_Challenge_6.Clases2;
using BootCamp_Challenge_6.Clases5;

namespace BootCamp_Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio5();
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

        static void Ejercicio5()
        {
            PilaGenerica<int> enteros = new PilaGenerica<int>();
            enteros.Agregar(3);
            enteros.Agregar(2);
            enteros.Agregar(1);

            PilaGenerica<string> cadena = new PilaGenerica<string>();
            cadena.Agregar("Hola");
            cadena.Agregar("Mundo");

            Console.WriteLine("\nPila Enteros:");
            enteros.Mostrar();
            Console.WriteLine("\nPila Cadena:");
            cadena.Mostrar();
            Console.Write($"\nDesapilo en Entero: {enteros.Desapilar()}");
            Console.WriteLine($"\nDesapilo en Cadena: {cadena.Desapilar()}");
            
            Console.WriteLine("\nResultado Entero:");
            enteros.Mostrar();
            Console.WriteLine("\nResultado Cadena:");
            cadena.Mostrar();

        }
    }
}
