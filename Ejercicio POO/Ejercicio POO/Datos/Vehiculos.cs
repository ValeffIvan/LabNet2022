using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_POO.Modelos;

namespace Ejercicio_POO.Datos
{
    internal class Vehiculos
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void agregar (Vehiculo vehiculo)
        {
            vehiculos.Add (vehiculo);
        }
        public List<Vehiculo> listar()
        {
            return this.vehiculos;
        }


    }
}
