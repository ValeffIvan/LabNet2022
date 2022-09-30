using Practica.EF.Entities;
using Practica.EF.Logic.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    internal class OrdersLogic : BaseLogic
    {

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

    }
}
