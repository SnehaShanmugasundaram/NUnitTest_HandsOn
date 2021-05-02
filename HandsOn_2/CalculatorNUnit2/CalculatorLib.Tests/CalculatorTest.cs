using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorNUnit2;
using System.Collections;

namespace CalculatorLib.Tests
{
    [TestFixture]
    [Author("Sri","Sri@cts.com")]
   
    class CalculatorTest
    {
       
        
        [TestCaseSource(nameof(CalcTestCases)),Order(1)]
        [Category("Category1")]
        public void AddTestMethod(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(num1, num2);
            Assert.That((num1>0 && num2>0)?num1+num2:0, Is.EqualTo(result));
        }

       
      
        [TestCaseSource(typeof(calcTestCases2)),Order(4)]
        [Category("Category2")]
        public void SubtractTestMethod(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(num1, num2);
            int expected = (num1 > 0 && num2 > 0) ? ((num1 > num2) ? (num1 - num2) : (num2 - num1)) : 0;
            Assert.That(expected, Is.EqualTo(result));
        }

       
       
        [TestCaseSource(nameof(CalcTestCases)),Order(2)]
        [Ignore("This can be seen later..Ignore it now")]
        public void MultiplyTestMethod(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(num1, num2);
            int expected = (num1 > 0 && num2 > 0) ? num1 * num2 : 0;
            Assert.That(expected, Is.EqualTo(result));
        }



        [TestCaseSource(typeof(calcTestCases2)),Order(3)]
        [Category("Category1")]
        public void DivideTestMethod(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(num1, num2);
            int expected = (num1 > 0 && num2 > 0) ? ((num1 > num2) ? (num1 / num2) : (num2 / num1)) : 0;
            Assert.That(result, Is.EqualTo(expected));
        }

        static readonly object[] CalcTestCases =
        {
            new object[] {1,2},
            new object[] {25,0 },
            new object[] {16,4}

        };


    }
     
    class calcTestCases2 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 100, 10 };
            yield return new object[] { 5, 7 };
            yield return new object[] { 15, 0 };
        }
    }
}
