using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Exceptions
{
    public class NotUniqueIdException : Exception
    {
        public NotUniqueIdException(string message) : base(@"One or more Elements have the same ID. 
                                                            Talk with the support service ")
        {
        }
    }
}
