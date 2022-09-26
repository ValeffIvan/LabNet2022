using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.EF.Logic.Control;
using Practica.EF.Logic.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Validation.Tests
{
    [TestClass()]
    public class SuppliersAndCustomersValidationTests
    {
        [TestMethod()]
        public void LengthAcceptedTest()
        {
            //Arrange
            string companyName = "AAA";
            string contactName = "BBB";
            string contactTitle = "CCC";
            string address = "DDD";
            string city = "EEE";
            string region = "FFF";
            string postalCode = "GGG";
            string country = "HHH";
            string phone = "III";
            string fax = "";

            SuppliersAndCustomersValidation validation = new SuppliersAndCustomersValidation();


            bool resultado;

            //Act

            resultado = validation.LengthAccepted(companyName, contactName, contactTitle, address, city, region,
                                         postalCode, country, phone, fax);

            //Assert

            Assert.AreEqual(resultado, true);
        }
    }
}