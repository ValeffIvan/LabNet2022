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
    public class SuppliersLogic:BaseLogic,ILogic<Suppliers>
    {

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
        public Suppliers GetSuppliers(int supplierID)
        {
            foreach (Suppliers suppliers in GetAll())
            {
                if (suppliers.SupplierID == supplierID)
                {
                    return suppliers;
                }
            }
            return null;
        }
        public string Add(Suppliers supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            return "Suppliers Added";
        }

        public bool Exist(int supplierID)
        {
            foreach (Suppliers suppliers in GetAll())
            {
                if (suppliers.SupplierID == supplierID)
                {
                    return true;
                }
            }
            return false;
        }
        public string Update(Suppliers suppliers)
        {
            try
            {
                if (Exist(suppliers.SupplierID))
                {
                    var suppliersUpdate = context.Suppliers.Find(suppliers.SupplierID);

                    suppliersUpdate = suppliers;
                    context.SaveChanges();
                    return "Supplier update";
                }
                else
                {
                    return "Supplier dont exist";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var customersDelete = context.Suppliers.Single(r => r.SupplierID == id);

                context.Suppliers.Remove(customersDelete);
                context.SaveChanges();
                return "Se ha eliminado con exito";
            }
            catch (NotUniqueIdException nex)
            {
                return nex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}
