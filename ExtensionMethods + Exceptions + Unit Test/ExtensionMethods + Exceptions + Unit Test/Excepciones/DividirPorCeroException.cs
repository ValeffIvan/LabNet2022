using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Excepciones
{
    internal class DividirPorCeroException:Exception
    {
        public DividirPorCeroException() : base("Solo Chuck Norris divide por cero!")
        { 
        
        }
    }
}
