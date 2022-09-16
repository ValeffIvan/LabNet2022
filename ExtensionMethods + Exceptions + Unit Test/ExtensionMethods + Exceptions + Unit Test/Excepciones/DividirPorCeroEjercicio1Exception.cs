using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Excepciones
{
    internal class DividirPorCeroEjercicio1Exception:Exception
    {
        public DividirPorCeroEjercicio1Exception() : base("No se puede dividir por 0")
        {

        }
    }
}
