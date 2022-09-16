using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Excepciones
{
    internal class NumeroInvalidoException:Exception
    {
        public NumeroInvalidoException() : base("Seguro Ingreso una letra o no ingreso nada!")
        {

        }
    }
}
