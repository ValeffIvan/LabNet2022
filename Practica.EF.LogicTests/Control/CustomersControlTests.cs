﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.EF.Logic.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control.Tests
{
    [TestClass()]
    public class CustomersControlTests
    {
        [TestMethod()]
        public void AddCustomerTest()
        {
            //Arrange
            string customerID = "ANATR";
            string companyName = "Ana Trujillo Emparedados y helados";
            string contactName = "Ana Trujillo";
            string contactTitle = "Owner";
            string address = "Avda. de la Constitución 2222";
            string city = "México D.F.";
            string region = "";
            string postalCode = "05021";
            string country = "Mexico";
            string phone = "(5) 555-4729";
            string fax = "(5) 555-3745";

            public string AddCustomer(string customerID, string companyName, string contactName,
                                  string contactTitle, string address, string city, string region,
                                  string postalCode, string country, string phone, string fax)


            Assert.Fail();
        }

    }
}