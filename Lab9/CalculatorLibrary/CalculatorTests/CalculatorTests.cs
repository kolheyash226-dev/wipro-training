using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    public class Tests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(15, calc.Add(10, 5));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.AreEqual(5, calc.Subtract(10, 5));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.AreEqual(50, calc.Multiply(10, 5));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        [Test]
        public void Divide_ByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }
    }
}
