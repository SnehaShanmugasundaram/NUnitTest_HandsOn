using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollectionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeM = new EmployeeManager();
            foreach (var items in employeeM.GetEmployees())
            {
                Console.WriteLine(items.EmpName);
                
            }
            Console.Read();
        }
    }
}
