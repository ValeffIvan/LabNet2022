using Ejercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO.Modelos
{
    internal class Omnibus : Vehiculo,IMoverse
    {
        public Omnibus(int numerodevehiculo, int cantidadPasajeros) : base(numerodevehiculo, cantidadPasajeros)
        {
            this.numero = numerodevehiculo;
            this.cantidadpasajeros = cantidadPasajeros;
        }

        public void Avanzar()
        {
            throw new NotImplementedException();
        }

        public void Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Omnibus numero {this.numero} con {this.cantidadpasajeros} cantidad de pasajeros";
        }
    }
}
