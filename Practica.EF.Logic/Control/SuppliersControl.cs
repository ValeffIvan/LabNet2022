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

        public string AddSuppliers(int SuppliersID, string CompanyName, string ContactName,
                                  string ContactTitle, string Address, string City, string Region,
                                  string PostalCode, string Country, string Phone, string Fax)
        {
            if (SuppliersID.ToString() != "" && CompanyName != "")
            {
                Suppliers supplies = new Suppliers();
                supplies.SupplierID = SuppliersID;
                supplies.CompanyName = CompanyName;
                supplies.ContactName = ContactName;
                supplies.ContactTitle = ContactTitle;
                supplies.Address = Address;
                supplies.City = City;
                supplies.Region = Region;
                supplies.PostalCode = PostalCode;
                supplies.Country = Country;
                supplies.Phone = Phone;
                supplies.Fax = Fax;
                if (!suppliersLogic.Exist(SuppliersID))
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
                return "CustomerID or CompanyName invalid";
            }

        }
    }
}
