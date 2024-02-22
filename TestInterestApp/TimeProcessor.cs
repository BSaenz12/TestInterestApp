using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterestApp
{
    public class TimeProcessor
    {

        public TimeUnit DetermineTimeUnit(string timeUnit)
        {

            switch ( timeUnit.ToUpper() )
            {
                case "D":
                    return TimeUnit.Days;
                case "W":
                    return TimeUnit.Weeks;
                case "M":
                    return TimeUnit.Months;
                case "Y":
                    return TimeUnit.Years;
                default: return TimeUnit.NoUnit;

            }
        }
    }
}
