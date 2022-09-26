using Practica.EF.Entities;
using Practica.EF.Logic.ExtensionMethods;
using Practica.EF.Logic.Logic;
using Practica.EF.Logic.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control
{
    public class SuppliersControl
    {
        SuppliersLogic suppliersLogic = new SuppliersLogic();
        SuppliersAndCustomersValidation validation = new SuppliersAndCustomersValidation();

        public List<Suppliers> GetAll()
        {
            return suppliersLogic.GetAll();
        }

        public string Delete(int suppliersID)
        {
            return suppliersLogic.Delete(suppliersID);
        }

        public Suppliers GetSuppliers(int suppliersID)
        {
            return suppliersLogic.GetSuppliers(suppliersID);
        }

        public string AddSuppliers(int suppliersID, string companyName, string contactName,
                                  string contactTitle, string address, string city, string region,
                                  string postalCode, string country, string phone, string fax,string homePage)
        {
            if (suppliersID.ToString() != "" && companyName != "")
            {
                if (validation.LengthAccepted(companyName,  contactName,  contactTitle,  address, city,  
                                              region,  postalCode, country, phone,  fax))
                {
                    Suppliers supplies = new Suppliers();
                    supplies.SupplierID = suppliersID;
                    supplies.CompanyName = companyName;
                    supplies.ContactName = contactName;
                    supplies.ContactTitle = contactTitle;
                    supplies.Address = address;
                    supplies.City = city;
                    supplies.Region = region;
                    supplies.PostalCode = postalCode;
                    supplies.Country = country;
                    supplies.Phone = phone;
                    supplies.Fax = fax;
                    supplies.HomePage = homePage;
                    if (!suppliersLogic.Exist(suppliersID))
                    {

                        return suppliersLogic.Add(supplies);
                    }
                    else
                    {

                        return suppliersLogic.Update(supplies);
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
