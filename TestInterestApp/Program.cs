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
Console.WriteLine("Please input a principle amount: ");

// Store the input into a variable
double principleAmount = 0.00;
principleAmount = Convert.ToDouble(Console.ReadLine());

if (validator.IsPositive(principleAmount) == false)
{
    Console.WriteLine("Principle amount should not be negative. Please try again.");
    Environment.Exit(0);
}


// Prompt user for interest rate
Console.WriteLine("Please input a interest rate: ");

// Store the input into a variable
double interestRate = 0.00;
interestRate = Convert.ToDouble(Console.ReadLine());

if (validator.IsPercentage(interestRate) == false)
{
    Console.WriteLine("Interest should not be negative, or greater than 1. Please try again.");
    Environment.Exit(0);
}

// Prompt user for term length
Console.WriteLine("Please input a term length: ");

// Store the input into a variable
double termLength = 0.00;
termLength = Convert.ToDouble(Console.ReadLine());

if (validator.IsPositive(termLength) == false)
{
    Console.WriteLine("Term length should not be negative. Please try again.");
    Environment.Exit(0);
}

// add another prompt for the time unit - days, weeks, months or years.
// Prompt user for term length
Console.WriteLine("Please input a term unit Days = Dd, Weeks = Ww, Months = Mm, Years = Yy (permitted characters -> Dd/Ww/Mm/Yy): ");
string termUnit = string.Empty;
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

TimeProcessor processor = new TimeProcessor();
TimeUnit timeUnit = processor.DetermineTimeUnit(termUnit);


// Add a 3-5 second sleep to simulate the processing
Console.WriteLine("\n\nCalculating your total interest... Crunching the numbers...\n\n");
Thread.Sleep(1500);

// Calculate the interest rate

// todo
// 1. add a function that'll handle the different term units
// 2. add a function that'll calculate the interest, total amount paid and principal balance throughout the term.
// 3. add functionality to display the calculations through time.
//      a. format the output neatly



// Add a case statement
// I want the app to support days, weeks, months and years.
// The app should calculate the amount of interest charges per day, week, month and year.
double total = principleAmount * interestRate * termLength;
Console.WriteLine("Your total interest is: " + total);


Console.WriteLine("Process Ending...");