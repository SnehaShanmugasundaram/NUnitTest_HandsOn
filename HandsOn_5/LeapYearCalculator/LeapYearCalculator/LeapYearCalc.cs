using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    public class LeapYearCalc
    {
        public int LeapYearMethod(DateTime year)
        {
            if(year.Year >= 1753 && year.Year <= 9999)
            {
                if(DateTime.IsLeapYear(year.Year))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
           
        }
    }
}
