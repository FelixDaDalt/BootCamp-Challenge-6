using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases6
{
    class ColaGenerica<T>
    {

        private List<T> genericos;


        public ColaGenerica()
        {
            genericos = new List<T>();

        }

        public void Agregar(T obj)
        {
            genericos.Insert(0, obj);
        }

        public T Desencolar()
        {
            T objeto = genericos.Last();
            genericos.Remove(objeto);
            return objeto;
        }

        public void Mostrar()
        {

            foreach (T objeto in genericos)
            {
                Console.WriteLine(objeto);
            }
        }

    }
}
