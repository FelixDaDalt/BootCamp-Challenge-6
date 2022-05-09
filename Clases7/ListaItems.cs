using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases7
{
    class ListaItems<T> : ListaDevPlace<T>
    {
        private List<T> listaItems = new List<T>();


        public ListaItems()
        {

        }

        public void AgregarItem(T obj)
        {
            listaItems.Add(obj);
        }

        public void BorrarItem(T obj)
        {
            listaItems.RemoveAll(listaItems => listaItems.Equals(obj));
        }

        public int CantidadItems()
        {
            return listaItems.Count(); 
        }

        public void ObtenerItem(int i)
        {
           Console.WriteLine($"Elemento: {listaItems[i]}");
        }
    }
}
