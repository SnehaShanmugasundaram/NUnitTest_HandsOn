using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDivideException
{
    public class CalculatorDivide
    {
        public int Divide(int dividend,int divisor)
        {
            if (divisor == 0)
                throw new ArgumentNullException("Divisor cannot be zero");
            return dividend / divisor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
