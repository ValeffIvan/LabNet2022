using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.ExtensionMethods
{
    public static class LengthExtension
    {
        public static bool LengthMax (this string aux, int i)
        {
            return aux.Length < i;
        }
    }
}
