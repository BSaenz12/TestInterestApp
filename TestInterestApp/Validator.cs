using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestInterestApp
{
    public class Validator
    {
        // todo
        // 1. add a validator function to ensure the values are positive
        public bool IsPositive(double numberToCheck)
        {
            return numberToCheck > 0;
        }

        // 2. add a validator function to ensure the interest rate is a percentage
        public bool IsPercentage(double numberToCheck)
        {
            return IsPositive( numberToCheck) && numberToCheck < 1;
        }

        // 3. add a validator function that checks if the term length is not greater than 100 years
        public bool ValidateDateUnit(string dateUnit)
        {

            try
            {
                Regex testrgx = new Regex("^[DdWwMmYy]$");

                Match testMtch = testrgx.Match(dateUnit);
                return testMtch.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred. Failure validating the date unit. Please try again.");
            }
            return false;         
        }


        // P.S. it'd be neat to add some unit tests to this project too.
        // Practice, practice, practice!
    }
}
