using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathLibraryTests;
using System.Collections;

namespace MathLibraryTest
{
    [TestFixture]
    public class MathLibTest
    {
        [Test]
        [TestCaseSource(nameof(CompareTwoNumbersTestData))]
        public void CompareTwoNosTestMethod(int firstNum,int secondNum,int expected)

        {
            try
            {
                MathLib mObj = new MathLib();
                int actualResult = mObj.CompareTwoNumbers(firstNum, secondNum);
                Assert.AreEqual(actualResult, expected);
            }
            catch(Exception)
            {
                Assert.Fail("Actual Result and Expected Result not matched");
            }
        }
        public static IEnumerable<TestCaseData> CompareTwoNumbersTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, 1);
                yield return new TestCaseData(1, 2, -1);
                yield return new TestCaseData(2, 1, 1);

            }
        }

    }
    
}
