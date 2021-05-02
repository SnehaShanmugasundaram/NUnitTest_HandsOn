using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollectionsTest
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName{ get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }

    public class EmployeeManager
    {
        private static readonly List<Employee> employees;

        static EmployeeManager()
        {
            employees = new List<Employee>
            {
                new Employee {EmpID=101, EmpName="Sri", DOJ=DateTime.Now.AddYears(-10),Salary=20000},
                new Employee {EmpID=102, EmpName="Naveen", DOJ=DateTime.Now.AddYears(-7),Salary=30000},
                new Employee {EmpID=103, EmpName="Shasvath", DOJ=DateTime.Now.AddYears(-4),Salary=40000},
                new Employee {EmpID=104, EmpName="Adhistha", DOJ=DateTime.Now.AddYears(-3),Salary=25000},
                new Employee {EmpID=105, EmpName="Dhansika", DOJ=DateTime.Now.AddYears(-2),Salary=37000}
            };
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return employees.FindAll(e => e.DOJ < DateTime.Now);
        }

    }
}
