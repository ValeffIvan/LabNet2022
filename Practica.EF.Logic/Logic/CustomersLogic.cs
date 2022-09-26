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
    public class CustomersLogic:BaseLogic, ILogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetCustomers (string customerID)
        {
            foreach (Customers customers in GetAll())
            {
                if (customers.CustomerID==customerID)
                {
                    return customers;
                }
            }
            return null;
        }
        public string Add(Customers customers)
        {
            context.Customers.Add(customers);
            context.SaveChanges();
            return "Customer Added";
        }

        public bool Exist(string customerID)
        {
            foreach (Customers customers in GetAll())
            {
                if (customers.CustomerID == customerID)
                {
                    return true;
                }
            }
            return false;
        }
        public string Update(Customers customers)
        {
            try
            {
                if (Exist(customers.CustomerID))
                {
                    var customerUpdate = context.Customers.Find(customers.CustomerID);

                    customerUpdate = customers;
                    context.SaveChanges();
                    return "Customer update";
                }
                else
                {
                    return "Costomer dont exist";
                }
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(string id)
        {
            try
            {
                var customersDelete = context.Customers.Single(r => r.CustomerID == id);

                context.Customers.Remove(customersDelete);
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
