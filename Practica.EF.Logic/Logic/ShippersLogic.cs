using Practica.EF.Data;
using Practica.EF.Entities;
using Practica.EF.Logic.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers, int>
    {
        public string Add(Shippers aux)
        {
            throw new NotImplementedException();
        }

        public string Delete(int aux)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public string Update(Shippers aux)
        {
            throw new NotImplementedException();
        }
    }
}
