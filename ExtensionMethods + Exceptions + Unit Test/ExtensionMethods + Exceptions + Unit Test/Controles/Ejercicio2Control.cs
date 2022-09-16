using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods___Exceptions___Unit_Test.Excepciones;

namespace ExtensionMethods___Exceptions___Unit_Test.Controles
{
    public class Ejercicio2Control
    {
        public string Dividir (decimal num1, decimal num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DividirPorCeroException();
                }
                else
                {
                    return $"Resultado: {(num1 / num2)}";
                }
            }
            catch (DividirPorCeroException dex)
            {
                return dex.Message;
            }
        }

    }
}
