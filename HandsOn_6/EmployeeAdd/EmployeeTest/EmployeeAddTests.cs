using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeAdd;

namespace EmployeeTest
{
    [TestFixture]
    class EmployeeAddTests
    {
        EmployeeManager employeeManager = new EmployeeManager();
        [Test]
        [TestCase]
        public void EmployeeAddTestMethod()
        {
            try
            {
                
                Employee employee = new Employee
                {
                    Id=101,
                    Name="Sri"
                };
                int beforeAdding = employeeManager.HeadCount;
                employeeManager.AddEmployee(employee);
                //Assert.Throws<ArgumentNullException>(() => employeeManager.AddEmployee(emp));
                int afterAdding = employeeManager.HeadCount;
                Assert.AreNotEqual(beforeAdding, afterAdding);
            }
            catch(Exception)
            {
                Assert.Fail("Inserting Employee Failed");
            }

        }
        [TestCase]
        public void TestNullException()
        {
            Employee emp = new Employee
            {
                Id=102,
                Name=null
            };
            Assert.Throws<ArgumentNullException>(() => employeeManager.AddEmployee(emp));
        }
    }
}
