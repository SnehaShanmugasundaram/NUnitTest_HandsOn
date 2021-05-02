using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeCollectionsTest;

namespace CollectionLib
{
    [TestFixture]
    public class EmployeeTest
    {
        EmployeeManager employeeM = new EmployeeManager();
        List<Employee> empList;
        [Test]
        public void CheckEmployee()
        {
            empList = employeeM.GetEmployees();
            foreach (var item in empList)
            {
                
                Assert.AreEqual(107,item.EmpID);
               
            }
        }

        [TestCase]
        public void EmployeeTestMethod()

        {
            empList = employeeM.GetEmployees();
            foreach (var items in empList)
            {
                Assert.IsNotNull(items.EmpID);
                Assert.IsNotNull(items.EmpName);
                Assert.IsNotNull(items.DOJ);
                Assert.IsNotNull(items.Salary);


            }

           // CollectionAssert.AllItemsAreNotNull(employeeM.GetEmployees());
            
        }
        [TestCase]
        public void TestCheck_ForAnyNUllValueInCollection()
        {
            try
            {
                EmployeeManager em = new EmployeeManager();
                empList = em.GetEmployees();
                foreach (var data in empList)
                {
                    Assert.IsNotNull(data.EmpID);
                    Assert.IsNotNull(data.EmpName);
                    Assert.IsNotNull(data.DOJ);
                    Assert.IsNotNull(data.Salary);
                }
            }
            catch (Exception)
            {
                Assert.Fail("The data in the collection should not be null");
            }
        }

    }
}
