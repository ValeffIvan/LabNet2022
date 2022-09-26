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

        public string AddCustomer(string customerID, string companyName, string contactName,
                                  string contactTitle, string address, string city, string region,
                                  string postalCode, string country, string phone, string fax)
        {
            if (customerID != "" && companyName != "")
            {
                if (companyName.Length <= 40 && contactName.Length <= 30 && contactTitle.Length <= 30 &&
                    address.Length <= 60 && city.Length <= 15 && region.Length <= 15 && postalCode.Length <= 10 &&
                    country.Length <= 15 && phone.Length <= 24 && fax.Length <= 24)
                {
                    Customers customers = new Customers();
                    customers.CustomerID = customerID;
                    customers.CompanyName = companyName;
                    customers.ContactName = contactName;
                    customers.ContactTitle = contactTitle;
                    customers.Address = address;
                    customers.City = city;
                    customers.Region = region;
                    customers.PostalCode = postalCode;
                    customers.Country = country;
                    customers.Phone = phone;
                    customers.Fax = fax;
                    if (!customersLogic.Exist(customerID))
                    {

                        return customersLogic.Add(customers);
                    }
                    else
                    {
                        return customersLogic.Update(customers);
                    }
                }
                else
                {
                    return "Valor invalido";
                }
            }
            else
            {
                return "CustomerID or CompanyName invalid";
            }
            
        }
    }
}
