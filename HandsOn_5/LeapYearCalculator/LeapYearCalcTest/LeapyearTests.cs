using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeapYearCalculator;
using System.Globalization;

namespace LeapYearCalcTest
{
    [TestFixture]
    class LeapyearTests
    {
        [Test]
        [TestCaseSource(nameof(LeapYearTestData))]
        public void LeapyearCalcTestMethod(string year,int expected)
        {

            LeapYearCalc lobj = new LeapYearCalc();
            DateTime nYear = DateTime.ParseExact(year, "yyyy",
                                    CultureInfo.InvariantCulture);
            int result = lobj.LeapYearMethod(nYear);
            try
            {
                Assert.AreEqual(expected, result);
            }
            catch(Exception)
            {
                Assert.Fail("Both the results not matched");
            }
        }
        public static IEnumerable<TestCaseData> LeapYearTestData
        {
            get
            {
                yield return new TestCaseData("1667", -1);
                yield return new TestCaseData("1772", 1);
                yield return new TestCaseData("2021", 0);

            }
        }
    }
}
