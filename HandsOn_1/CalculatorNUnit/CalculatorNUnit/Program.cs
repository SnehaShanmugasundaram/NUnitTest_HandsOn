using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNUnit
{
    public class Calculator
    {
        public int Add(int firstNum,int secondNum)
        {
            if(firstNum>0 && secondNum>0)
            {
                return (firstNum + secondNum);
            }
            else
            {
                return 0;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
