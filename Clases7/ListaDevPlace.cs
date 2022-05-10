using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_6.Clases7
{
    interface ListaDevPlace<T>
    {
        void AgregarItem(T obj);

        void BorrarItem(T obj);

        void ObtenerItem(int i);

        int CantidadItems();

    }
}
