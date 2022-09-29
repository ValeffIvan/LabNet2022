using Practica.EF.Data;
using Practica.EF.Entities;
using Practica.EF.Logic.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class ProductsLogic:BaseLogic, ILogic<Products, string>
    {
        public string Add(Products aux)
        {
            throw new NotImplementedException();
        }

        public string Delete(string aux)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public string Update(Products aux)
        {
            throw new NotImplementedException();
        }

        List<Products> ILogic<Products, string>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
