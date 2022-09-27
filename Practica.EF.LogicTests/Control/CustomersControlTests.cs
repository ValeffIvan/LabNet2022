using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Practica.EF.Data;
using Practica.EF.Entities;
using Practica.EF.Logic.Control;
using Practica.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var mockSet = new Mock<DbSet<Customers>>();

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            CustomersLogic customersLogic = new CustomersLogic(mockContext.Object);

            customersLogic.Add(new Customers
            {
                CustomerID = "ANATR",
                CompanyName = "Ana Trujillo Emparedados y helados",
                ContactName = "Anaa Trujillo",
                ContactTitle = "Owner",
                Address = "Avda. de la Constitución 2222",
                City = "México D.F.",
                Region = "",
                PostalCode = "05021",
                Country = "Mexico",
                Phone = "(5) 555-4729",
                Fax = "(5) 555-3745",
            });

            mockSet.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());


        }
    }
}