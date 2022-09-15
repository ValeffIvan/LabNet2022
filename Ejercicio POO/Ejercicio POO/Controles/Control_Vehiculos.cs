using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_POO.Datos;
using Ejercicio_POO.Modelos;

namespace Ejercicio_POO.Controles
{
    internal class Control_Vehiculos
    {
        int contomnibus=0;
        int conttaxi=0;
        Vehiculos vehiculos = new Vehiculos();

        public string agregar(string tipovehiculo, int cantidadpasajeros)
        {

            if (tipovehiculo != "")
            {
                Vehiculo vehiculo;
                if (tipovehiculo == "Omnibus")
                {
                    if (contomnibus <= 4)
                    {
                        contomnibus++;
                        vehiculo = new Omnibus(contomnibus,cantidadpasajeros);
                        vehiculos.agregar(vehiculo);
                        return $"Vehiculo cargado con exito";
                    }
                    else
                    {
                        return $"Cantidad de omnibus maxima";
                    }
                }
                else
                {
                    if (conttaxi <= 4)
                    {
                        conttaxi++;
                        vehiculo = new Taxi(conttaxi,cantidadpasajeros);
                        vehiculos.agregar(vehiculo);
                        return $"Vehiculo cargado con exito";
                    }
                    else
                    {
                        return $"Cantidad de taxis maxima";
                    }
                }
            }
            else
            {
                return $"Seleccione tipo de vehiculo";
            }
        }

        public List<Vehiculo> listar ()
        {
            return vehiculos.listar();
        }
    }
}
