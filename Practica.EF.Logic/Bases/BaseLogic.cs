using Practica.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Bases
{
    public class BaseLogic
    {
        protected NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
