using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods___Exceptions___Unit_Test.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Controles.Tests
{
    [TestClass()]
    public class ControlEjercicio1Tests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //Arrange
            decimal num1 = 6;
            decimal num2 = 0;
            ControlEjercicio2 control = new ControlEjercicio2();

            //Act
            string resultado=control.Dividir(num1, num2);

            //Assert
            Assert.AreEqual(resultado, "Solo Chuck Norris divide por cero!");
        }
    }
}