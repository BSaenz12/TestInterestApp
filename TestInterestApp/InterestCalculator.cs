using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterestApp
{
    public class InterestCalculator
    {

        // This will be the "engine" class that'll be responsible for doing the calculations.

        // to do
        // 1. add a function that'll calculate the interest rate.
        public double CalculateInterestRate(TimeUnit termLengthUnit,
            double interestRate, double termLength)
        {
            // convert time unit into years since the app takes an APR only
            switch (termLengthUnit)
            {
                case TimeUnit.Days: return interestRate / 365;
                case TimeUnit.Weeks: return interestRate / 52;
                case TimeUnit.Months: return interestRate / 12;
                case TimeUnit.Years: return interestRate;
            }

            // calculate the interest rate

            // print out the interest rates and corresponding values


            return 0.00;
        }

        public void PrintInterestRates(TimeUnit termLengthUnit, double principalAmount,
            double interestRate, double termLength, double paymentToPrincipal)
        {
            string termUnit = string.Empty;

            switch (termLengthUnit)
            {
                case TimeUnit.Days:
                    termUnit = "Daily";
                    break;
                case TimeUnit.Weeks:
                    termUnit = "Weekly";
                    break;
                case TimeUnit.Months:
                    termUnit = "Monthly";
                    break;
                case TimeUnit.Years:
                    termUnit = "Yearly";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total number of " + termLengthUnit + ": " + termLength);
            Console.WriteLine("Interest rate is: " + interestRate);
            Console.WriteLine(termUnit + " payment to principal: " + paymentToPrincipal);
            Console.WriteLine("--------------------------------------------\n\n");
            for(int x=1; x <=termLength; x++)
            {
                var newPrincipalPayment = paymentToPrincipal * x;
                var newPrincipalAmount = (principalAmount - newPrincipalPayment);

                Console.WriteLine(termLengthUnit + " #" + x + " Interest rate amount: " +
                    (newPrincipalAmount * interestRate *x).ToString("C") +"  " + termUnit + " principal payment amount: " +
                    (newPrincipalPayment).ToString("C") + " New principal amount: " + newPrincipalAmount.ToString("C"));

            }
        }

        // 2. add a function that'll write out the amounts throughout the term length.
    }
}
