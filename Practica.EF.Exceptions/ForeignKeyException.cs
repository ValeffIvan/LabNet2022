using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Exceptions
{
    public class ForeignKeyException : Exception
    {
        public ForeignKeyException(string message) : base(@"Cannot be deleted because it is linked to another table. Talk with the support service ")
        {
        }
    }
}
