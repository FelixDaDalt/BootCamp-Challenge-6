using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_6.Clases;
using BootCamp_Challenge_6.Clases2;
using BootCamp_Challenge_6.Clases5;
using BootCamp_Challenge_6.Clases6;

namespace BootCamp_Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio5();
            //Ejercicio6();
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
            Console.WriteLine("PILA GENERICA :::::::::::::::::");
            PilaGenerica<int> enteros = new PilaGenerica<int>();
            for(int x=0; x<3;x++)
            {
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                enteros.Agregar(num);
            }

            PilaGenerica<string> cadena = new PilaGenerica<string>();
            for (int x = 0; x < 3; x++)
            {
                Console.Write("Cadena: ");
                string texto = Console.ReadLine();
                cadena.Agregar(texto);
            }
            Console.Clear();
            Console.WriteLine("Pila Enteros:");
            enteros.Mostrar();
            Console.WriteLine("Pila Cadena:");
            cadena.Mostrar();
            Console.Write($"\nDesapilo en Entero: {enteros.Desapilar()}");
            Console.WriteLine($"\nDesapilo en Cadena: {cadena.Desapilar()}");
            
            Console.WriteLine("\nResultado Entero:");
            enteros.Mostrar();
            Console.WriteLine("\nResultado Cadena:");
            cadena.Mostrar();
            Console.ReadKey();
            Console.Clear();
        }
        
        static void Ejercicio6()
        {
            Console.WriteLine("COLA GENERICA :::::::::::::::::");
            ColaGenerica<int> enteros = new ColaGenerica<int>();
            for (int x = 0; x < 3; x++)
            {
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                enteros.Agregar(num);
            }

            ColaGenerica<string> cadena = new ColaGenerica<string>();
            for (int x = 0; x < 3; x++)
            {
                Console.Write("Cadena: ");
                string texto = Console.ReadLine();
                cadena.Agregar(texto);
            }

            Console.Clear();
            Console.WriteLine("Cola Enteros:");
            enteros.Mostrar();
            Console.WriteLine("Cola Cadena:");
            cadena.Mostrar();
            Console.Write($"\nDesencolo en Entero: {enteros.Desencolar()}");
            Console.WriteLine($"\nDesencolo en Cadena: {cadena.Desencolar()}");

            Console.WriteLine("\nResultado Entero:");
            enteros.Mostrar();
            Console.WriteLine("\nResultado Cadena:");
            cadena.Mostrar();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
