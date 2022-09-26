using Practica.EF.Entities;
using Practica.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control
{
    public class CustomersControl
    {
        CustomersLogic customersLogic = new CustomersLogic();

        public List<Customers> GetAll ()
        {
            return customersLogic.GetAll ();
        }

        public string Delete (string customerID)
        {
            return customersLogic.Delete (customerID);
        }

        public Customers GetCustomer (string CustomerID)
        {
            return customersLogic.GetCustomers(CustomerID);
        }

        public string AddCustomer(string CustomerID, string CompanyName, string ContactName,
                                  string ContactTitle, string Address, string City, string Region,
                                  string PostalCode, string Country, string Phone, string Fax)
        {
            if (CustomerID != "" && CompanyName != "")
            {
                Customers customers = new Customers();
                customers.CustomerID = CustomerID;
                customers.CompanyName = CompanyName;
                customers.ContactName = ContactName;
                customers.ContactTitle = ContactTitle;
                customers.Address = Address;
                customers.City = City;
                customers.Region = Region;
                customers.PostalCode = PostalCode;
                customers.Country = Country;
                customers.Phone = Phone;
                customers.Fax = Fax;
                if (!customersLogic.Exist(CustomerID))
                {
                   
                    return  customersLogic.Add(customers);
                }
                else
                {
                    
                    return customersLogic.Update(customers);
                }
            }
            else
            {
                return "CustomerID or CompanyName invalid";
            }
            
        }
    }
}
