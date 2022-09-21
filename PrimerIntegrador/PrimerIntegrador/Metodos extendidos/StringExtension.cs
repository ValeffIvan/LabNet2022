using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerIntegrador.Metodos_extendidos
{
    public static class StringExtension
    {
        public static decimal convertstring (this string aux)
        {
            return Convert.ToDecimal (aux);
        }
    }
}
