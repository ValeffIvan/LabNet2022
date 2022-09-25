using Practica.EF.Data;
using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic
{
    public class CustomersLogic
    {
        private readonly NorthwindContext context;

        public CustomersLogic()
        {
            context = new NorthwindContext();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
