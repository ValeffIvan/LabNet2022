using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Exceptions
{
    public class ForeignKeyException : Exception
    {
        public ForeignKeyException(string message) : base(@"Can't remove the customer. Talk with the support service ")
        {
        }
    }
}
