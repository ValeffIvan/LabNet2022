using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerIntegrador.Excepciones;

namespace PrimerIntegrador.Controles
{
    internal class Ejercicio1Control
    {
        public string Dividir (decimal num1)
        {
            try
            {
                throw new DivideByZeroException ();
            }
            catch (DivideByZeroException dex)
            {
                return dex.Message;
            }
            
        }
    }
}
