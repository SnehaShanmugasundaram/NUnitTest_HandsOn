using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNUnit2
{
    public class Calculator
    {
        public int Add(int firstNum, int secondNum)
        {
            if (firstNum > 0 && secondNum > 0)
            {
                return (firstNum + secondNum);
            }
            else
            {
                return 0;
            }
        }

        public int Subtract(int firstNum, int secondNum)
        {
            if (firstNum > 0 && secondNum > 0)
            {
                return (firstNum > secondNum) ? (firstNum - secondNum) : (secondNum - firstNum);
            }
            else
            {
                return 0;
            }
        }

        public int Multiply(int firstNum,int secondNum)
        {
            if (firstNum > 0 && secondNum > 0)
            {
                return (firstNum * secondNum);
            }
            else
            {
                return 0;
            }
        }

        public int Divide(int firstNum, int secondNum)
        {
            if (firstNum > 0 && secondNum > 0)
            {
                return (firstNum > secondNum) ? (firstNum / secondNum) : (secondNum / firstNum);
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
