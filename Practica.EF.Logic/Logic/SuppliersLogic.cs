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
    public class SuppliersLogic:BaseLogic
    {

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }


    }
}
