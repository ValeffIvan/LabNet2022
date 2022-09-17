using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Metodos_extendidos
{
    public static class StringExtension
    {
        public static decimal convertstring (this string aux)
        {
            return Convert.ToDecimal (aux);
        }
    }
}
