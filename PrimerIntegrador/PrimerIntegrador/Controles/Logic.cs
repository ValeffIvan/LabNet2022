using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerIntegrador.Excepciones
{
    internal class Logic
    {
        public Exception TirarExcepcion()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException sfex)
            {
                return sfex;
            }
            catch (Exception ex)
            {
                return ex;
            }

        }
    }
}
