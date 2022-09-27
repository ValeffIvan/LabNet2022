﻿using Practica.EF.Data;
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
    public class CustomersLogic:BaseLogic, ILogic<Customers,string>
    {
        public CustomersLogic() { }
        public CustomersLogic(NorthwindContext contextd)
        {
            context = contextd;
        }
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

                    customerUpdate.CustomerID = customers.CustomerID;
                    customerUpdate.Address = customers.Address;
                    customerUpdate.Phone = customers.Phone;
                    customerUpdate.Fax = customers.Fax;
                    customerUpdate.City = customers.City;
                    customerUpdate.CompanyName = customers.CompanyName;
                    customerUpdate.Country = customers.Country;
                    customerUpdate.Region = customers.Region;
                    customerUpdate.PostalCode = customers.PostalCode;
                    customerUpdate.ContactTitle = customers.ContactTitle;
                    customerUpdate.ContactName= customers.ContactName;

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
                var customersDelete = context.Customers.First(r => r.CustomerID == id);
                context.Customers.Remove(customersDelete);
                context.SaveChanges();
                return "Se ha eliminado con exito";
            }
            catch (Exception ex)
            {
                ForeignKeyException foreignKeyException = ex as ForeignKeyException;
                return ex.Message;
            }
        }
    }
}
