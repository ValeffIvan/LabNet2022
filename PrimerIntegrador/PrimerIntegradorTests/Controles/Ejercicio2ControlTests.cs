using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods___Exceptions___Unit_Test.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods___Exceptions___Unit_Test.Metodos_extendidos;

namespace ExtensionMethods___Exceptions___Unit_Test.Controles.Tests
{
    [TestClass()]
    public class Ejercicio2ControlTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //Arrange
            string num1 = "6";
            string num2 = "0";
            Ejercicio2Control control = new Ejercicio2Control();

            //Act
            string resultado = control.Dividir(num1, num2);

            //Assert
            Assert.AreEqual(resultado, "Solo Chuck Norris divide por cero!");
        }

        [TestMethod()]
        public void DividirTest1()
        {
            //Arrange
            string num1 = "fwefw";
            string num2 = "fwe";
            Ejercicio2Control control = new Ejercicio2Control();

            //Act
            string resultado = control.Dividir(num1, num2);

            //Assert
            Assert.AreEqual(resultado, "Numero invalido");
        }

        [TestMethod()]
        public void DividirTest2()
        {
            //Arrange
            string num1 = "6";
            string num2 = "2";
            Ejercicio2Control control = new Ejercicio2Control();

            //Act
            string resultado = control.Dividir(num1, num2);

            //Assert
            Assert.AreEqual(resultado, "Resultado: 3");
        }
    }
}