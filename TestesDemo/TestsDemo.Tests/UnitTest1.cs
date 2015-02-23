using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesDemo;

namespace TestsDemo.Tests
{
    [TestClass] //Atributos
    public class UnitTest1
    {
        [TestMethod]
        public void Adiciona_2_e_2_retorna_4()
        {
            // Arrange
            var calc = new Calculadora();


            // Act
            int expect = 4;
            int actual = calc.Adicionar(2, 2);


            // Assert
            Assert.AreEqual(expect, actual);


        }
    }
}
