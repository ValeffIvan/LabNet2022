using PrimerIntegrador.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerIntegrador.Controles
{
    internal class LogicEj4
    {
        public Exception TirarExcepcion()
        {
            try
            {
                throw new PersoException();
            }
            catch (PersoException pfex)
            {
                return pfex;
            }
            catch (Exception ex)
            {
                return ex;
            }

        }
    }
}
