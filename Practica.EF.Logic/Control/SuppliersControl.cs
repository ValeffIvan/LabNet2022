using Practica.EF.Entities;
using Practica.EF.Logic.Logic;
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

        public bool LengthAccepted(string companyName, string contactName, string contactTitle, string address,
                           string city, string region, string postalCode, string country,
                           string phone, string fax)
        {
            if (companyName.Length <= 40 && contactName.Length <= 30 && contactTitle.Length <= 30 &&
                    address.Length <= 60 && city.Length <= 15 && region.Length <= 15 && postalCode.Length <= 10 &&
                    country.Length <= 15 && phone.Length <= 24 && fax.Length <= 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AddSuppliers(int suppliersID, string companyName, string contactName,
                                  string contactTitle, string address, string city, string region,
                                  string postalCode, string country, string phone, string fax,string homePage)
        {
            if (suppliersID.ToString() != "" && companyName != "")
            {
                if (LengthAccepted(companyName,  contactName,  contactTitle,  address, city,  region,  postalCode,  
                                  country, phone,  fax))
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
