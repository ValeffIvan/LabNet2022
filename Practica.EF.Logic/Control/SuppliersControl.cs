using Practica.EF.Entities;
using Practica.EF.Logic.ExtensionMethods;
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
            if (companyName.LengthMax (40) && contactName.LengthMax(30) && contactTitle.LengthMax(30) &&
                    address.LengthMax (60) && city.LengthMax (15) && region.LengthMax(15) && postalCode.LengthMax(10) &&
                    country.LengthMax (15) && phone.LengthMax(24) && fax.LengthMax(24))
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
