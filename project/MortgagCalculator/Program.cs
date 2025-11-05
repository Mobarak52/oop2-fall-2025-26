using System;
using System.Globalization;
class Program
{
static void Main() 

{
        CultureInfo bdCulture = new CultureInfo("bn-BD");
        Console.WriteLine ("Loan Calculator (BDT)");

        Console.Write("Enter Loan Amount (BDT): ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Annual Interest Rate (%): ");
        double annualInterestRate = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Loan Duration (in Months): ");
    int months = Convert.ToInt32(Console.ReadLine());
    double monthlyRate = (annualInterestRate / 100) / 12;
    double monthlyPayment = (principal * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -months));
    double totalPaid = monthlyPayment * months;
    double totalInterest = totalPaid - principal;
        CultureInfo bdCultureInfo = new CultureInfo("bn-BD");

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
}
}