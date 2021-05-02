using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryTests
{
    public class MathLib
    {
        public int CompareTwoNumbers(int num1,int num2)
        {
            if(num1<=0 && num2<=0)
            {
                return 0;
            }
            else if(num1>=num2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
