using Ejercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO.Modelos
{
    internal class Taxi : Vehiculo,IMoverse
    {
        public Taxi(int numerodevehiculo, int cantidadPasajeros) : base(numerodevehiculo, cantidadPasajeros)
        {
            this.cantidadpasajeros = cantidadPasajeros;
            this.numero = numerodevehiculo;
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
            return $"Taxi numero {this.numero} con {this.cantidadpasajeros} cantidad de pasajeros";
        }
    }
}
