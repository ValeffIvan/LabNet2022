using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerIntegrador.Excepciones
{
    internal class PersoException:Exception
    {
        public PersoException() : base("Excepcion personalizada")
        {

        }
    }
}
