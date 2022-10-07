using Practica.EF.Data;
using Practica.EF.Entities;
using Practica.EF.Exceptions;
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
            context.Shippers.Add(aux);
            context.SaveChanges();
            return "Shippers Added";
        }

        public string Delete(int id)
        {
            try
            {
                var shippersDelete = context.Shippers.First(r => r.ShipperID == id);
                context.Shippers.Remove(shippersDelete);
                context.SaveChanges();
                return "Se ha eliminado con exito";
            }
            catch (Exception ex)
            {
                ForeignKeyException foreignKeyException = new ForeignKeyException("Error");
                return foreignKeyException.Message;
            }
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public string Update(Shippers shippers)
        {
            try
            {
                var shippersUpdate = context.Shippers.Find(shippers.ShipperID);
                shippersUpdate.Phone = shippers.Phone;
                shippersUpdate.CompanyName = shippers.CompanyName;
                context.SaveChanges();
                return "Shipper update";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
