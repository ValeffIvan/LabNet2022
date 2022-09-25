using Practica.EF.Data;
using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic
{
    public class SuppliersLogic
    {
        private readonly NorthwindContext context;

        public SuppliersLogic()
        {
            context = new NorthwindContext();
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
    }
}
