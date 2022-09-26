using Practica.EF.Entities;
using Practica.EF.Logic.ExtensionMethods;
using Practica.EF.Logic.Logic;
using Practica.EF.Logic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control
{
    public class CustomersControl
    {
        CustomersLogic customersLogic = new CustomersLogic();
        SuppliersAndCustomersValidation validation = new SuppliersAndCustomersValidation();
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

        public bool LengthAccepted (string companyName, string contactName,string contactTitle, string address, 
                                   string city, string region, string postalCode, string country, 
                                   string phone, string fax)
        {
            if (companyName.LengthMax(40) && contactName.LengthMax(30) && contactTitle.LengthMax(30) &&
                    address.LengthMax(60) && city.LengthMax(15) && region.LengthMax(15) && postalCode.LengthMax(10) &&
                    country.LengthMax(15) && phone.LengthMax(24) && fax.LengthMax(24))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AddCustomer(string customerID, string companyName, string contactName,
                                  string contactTitle, string address, string city, string region,
                                  string postalCode, string country, string phone, string fax)
        {
            if (customerID != "" && companyName != "")
            {
                if (LengthAccepted(companyName,  contactName,  contactTitle,  address, city,  region,  postalCode, 
                                  country, phone,  fax))
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
