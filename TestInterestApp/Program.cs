// See https://aka.ms/new-console-template for more information
using TestInterestApp;

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> INTEREST RATE CALCULATOR APP <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


// Bruno Saenz - 2/20/2024
// This is a simple console application that'll intake a principle amount, interest rate and term length.
Console.WriteLine("Starting Process...");
Console.WriteLine("Hello, I'm the Interest Rate Calculator Console app.\n\n\n");
Console.WriteLine("Please provide a principle amount, interest rate and term length respectively. Note: The inputs MUST be greater than zero.");

Validator validator = new();


// Prompt user for principle amount
Console.WriteLine("Please input a principal amount: ");

// Store the input into a variable
double principalAmount = 0.00;
principalAmount = Convert.ToDouble(Console.ReadLine());

if (validator.CheckIfInputIsPositive(principalAmount) == false)
{
    Console.WriteLine("Principal amount should not be negative. Please try again.");
    Environment.Exit(0);
}


// Prompt user for interest rate
Console.WriteLine("Please input a interest rate (APR/Annual Percentage Rate): ");

// Store the input into a variable
double interestRate = 0.00;
interestRate = Convert.ToDouble(Console.ReadLine());

if (validator.CheckIfInputIsPercentage(interestRate) == false)
{
    Console.WriteLine("Interest should not be negative, or greater than 1. Please try again.");
    Environment.Exit(0);
}

// Prompt user for term length
Console.WriteLine("Please input a term length: ");

// Store the input into a variable
double termLength = 0.00;
termLength = Convert.ToDouble(Console.ReadLine());

if (validator.CheckIfInputIsPositive(termLength) == false)
{
    Console.WriteLine("Term length should not be negative. Please try again.");
    Environment.Exit(0);
}

// add another prompt for the time unit - days, weeks, months or years.
// Prompt user for term length
Console.WriteLine("Please input a term unit Days = Dd, Weeks = Ww, Months = Mm, Years = Yy (permitted characters -> Dd/Ww/Mm/Yy): ");
string? termUnit = string.Empty;
termUnit = Console.ReadLine();

if (string.IsNullOrEmpty(termUnit))
{
    Console.WriteLine("Term length should not be empty. Please try again.");
    Environment.Exit(0);
}
else if (validator.ValidateDateUnit(termUnit) == false)
{
    Console.WriteLine("Failure validating the date unit. Please try again.");
}

// Prompt user for principle amount
Console.WriteLine("Please input a payment to principal amount: ");

// Store the input into a variable
double principalToPaymentAmount = 0.00;
principalToPaymentAmount = Convert.ToDouble(Console.ReadLine());

if (validator.CheckIfInputIsPositive(principalToPaymentAmount) == false)
{
    Console.WriteLine("Payment to principal amount should not be negative. Please try again.");
    Environment.Exit(0);
}

TimeProcessor processor = new TimeProcessor();
TimeUnit timeUnitTest = processor.IdentifyTimeUnit(termUnit);


// Add a 3-5 second sleep to simulate the processing
Console.WriteLine("\n\nCalculating your total interest... Crunching the numbers...\n\n");
Thread.Sleep(1500);

// Calculate the interest rate

// todo
// 1. add a function that'll handle the different term units

// 2. add a function that'll calculate the interest, total amount paid and principal balance throughout the term.
var interestCalculator = new InterestCalculator();

Double testIntRate = interestCalculator.CalculateInterestRate(timeUnitTest, interestRate, termLength);

// 3. add functionality to display the calculations through time.
//      a. format the output neatly
interestCalculator.PrintInterestRates(timeUnitTest, principalAmount, testIntRate,
    termLength, principalToPaymentAmount);

// As of 10/12/2024
// Need to refine the principal amount logic/functionality.
// Need to pay the loan in its entirety.



// Add a case statement
// I want the app to support days, weeks, months and years.
// The app should calculate the amount of interest charges per day, week, month and year.


//double total = principalAmount * interestRate * termLength;
//Console.WriteLine("Your total interest is: " + total);


Console.WriteLine("Process Ending...");