using Practica.EF.Entities;
using Practica.EF.Logic.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    internal class OrdersLogic : BaseLogic, ILogic<Orders, string>
    {
        public string Add(Orders aux)
        {
            throw new NotImplementedException();
        }

        public string Delete(string aux)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public string Update(Orders aux)
        {
            throw new NotImplementedException();
        }
    }
}
