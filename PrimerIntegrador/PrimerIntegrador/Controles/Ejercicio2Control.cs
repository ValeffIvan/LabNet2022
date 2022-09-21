using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerIntegrador.Excepciones;
using PrimerIntegrador.Metodos_extendidos;

namespace PrimerIntegrador.Controles
{
    public class Ejercicio2Control
    {
        public string Dividir (string num1, string num2)
        {
            try
            {
                decimal numero1 = num1.convertstring();
                decimal numero2 = num2.convertstring();
                if (numero2 == 0)
                {
                    throw new DividirPorCeroException();
                }
                else
                {
                    return $"Resultado: {(numero1 / numero2)}";
                }
            }
            catch (FormatException nex)
            {
                return "Numero invalido";
            }
            catch (DividirPorCeroException dex)
            {
                return dex.Message;
            }
        }

    }
}
