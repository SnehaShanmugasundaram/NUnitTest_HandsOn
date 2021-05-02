using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorDivideException;


namespace CalcularDivideTest
{
    [TestFixture]
    
    public class DivideExceptionTest
    {
        CalculatorDivide calculatorDivide = new CalculatorDivide();
        [TestCase]
        public void DivideTestNullException()
        {
            Assert.Throws<ArgumentNullException>(() => calculatorDivide.Divide(12, 0));
        }

    }
}
