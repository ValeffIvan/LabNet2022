using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO.Modelos
{
    internal abstract class Vehiculo
    {
        public int numero;
        public int cantidadpasajeros;

        public Vehiculo (int numerodevehiculo,int cantidadPasajeros)
        {
            numero = numerodevehiculo;
            cantidadpasajeros = cantidadPasajeros;
        }

    }
}
