using ExtensionMethods___Exceptions___Unit_Test.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Controles
{
    internal class Ejercicio1Control
    {
        public string Dividir (decimal num1)
        {
            try
            {
                throw new DividirPorCeroEjercicio1Exception();
            }
            catch (DividirPorCeroEjercicio1Exception dex)
            {
                return dex.Message;
            }
            
        }
    }
}
