using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_6.Clases;
using BootCamp_Challenge_6.Clases2;
using BootCamp_Challenge_6.Clases3;
using BootCamp_Challenge_6.Clases5;
using BootCamp_Challenge_6.Clases6;
using BootCamp_Challenge_6.Clases7;
using BootCamp_Challenge_6.Extension;

namespace BootCamp_Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
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

        static void Ejercicio3()
        {
            Persona persona1 = new Persona("Felix", new DateTime(1985,10,12));
            persona1.getNombre();
            persona1.edad();
            
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

        static void Ejercicio7()
        {
            ListaItems<int> numero = new ListaItems<int>();

            #region ENTEROS
            for (int x=0; x < 5;x++)
            {
                Console.Write("Numero: ");
                numero.AgregarItem(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Mostrar");
            for (int x = 0; x < numero.CantidadItems(); x++)
            {
                numero.ObtenerItem(x);
            }
            Console.WriteLine($"Cantidad elementos: {numero.CantidadItems()}");
            
            Console.Write("Borrar el: ");
            numero.BorrarItem(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("Mostrar");
            for (int x = 0; x < numero.CantidadItems(); x++)
            {
                numero.ObtenerItem(x);
            }
            Console.WriteLine($"Cantidad elementos: {numero.CantidadItems()}");
            #endregion

            ListaItems<string> cadena = new ListaItems<string>();
            #region CADENA

            for (int x = 0; x < 5; x++)
            {
                Console.Write("texto: ");
                cadena.AgregarItem(Console.ReadLine());
            }
            Console.WriteLine("Mostrar");
            for (int x = 0; x < cadena.CantidadItems(); x++)
            {
                cadena.ObtenerItem(x);
            }
            Console.WriteLine($"Cantidad elementos: {cadena.CantidadItems()}");
            Console.Write("Borrar el: ");
            cadena.BorrarItem(Console.ReadLine());
            Console.WriteLine("Mostrar");
            for (int x = 0; x < cadena.CantidadItems(); x++)
            {
                cadena.ObtenerItem(x);
            }
            Console.WriteLine($"Cantidad elementos: {cadena.CantidadItems()}");
            #endregion

        }

        static void Ejercicio8()
        {
            string texto = "hola mundo";
            Console.WriteLine(texto.primeraMidad());

            Console.WriteLine(texto.segundaMidad());
        }

        static void Ejercicio9()
        {
            Persona per = new Persona("felix", new DateTime(1985, 10, 12));
            if (per.mayorEdad())
                Console.WriteLine("Es Mayor");
            else
                Console.WriteLine("Es Menor");
        }
    }
}
