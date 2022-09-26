using Practica.EF.Logic.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Validation
{
    public class SuppliersAndCustomersValidation
    {
        public bool LengthAccepted(string companyName, string contactName, string contactTitle, string address,
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
    }
}
