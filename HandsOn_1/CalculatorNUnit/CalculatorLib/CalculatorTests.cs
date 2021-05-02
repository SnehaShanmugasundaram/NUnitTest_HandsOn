using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorNUnit;

namespace CalculatorLib
{
    [TestFixture]
    class CalculatorTests
    {


        [Test]
        [TestCase(2,4,6)]
        [TestCase(0,7,0)]
        public void AddTestMethod(int num1,int num2,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(num1, num2);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
