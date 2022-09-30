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
    public class ProductsLogic:BaseLogic
    {


        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

    }
}
