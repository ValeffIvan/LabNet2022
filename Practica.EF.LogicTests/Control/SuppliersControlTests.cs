using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.EF.Logic.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control.Tests
{
    [TestClass()]
    public class SuppliersControlTests
    {
        [TestMethod()]
        public void LengthAceptedTest()
        {
            //Arrange
            string companyName = "New Orleans Cajun Delights";
            string contactName = "Shelley Burke";
            string contactTitle = "Order Administrator";
            string address = "P.O. Box 78934";
            string city = "New Orleans";
            string region = "LA";
            string postalCode = "70117";
            string country = "USA";
            string phone = "(100) 555-4822";
            string fax = "";

            SuppliersControl suppliersControl = new SuppliersControl();


            bool resultado;

            //Act

            resultado = suppliersControl.LengthAccepted( companyName, contactName, contactTitle, address, city, region,
                                         postalCode, country, phone, fax);

            //Assert

            Assert.AreEqual(resultado, true);
        }
    }
}