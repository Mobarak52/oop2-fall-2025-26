using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double salary = 0;
        double creditScore = 0;
        bool criminalRecord = false;

       
        while (true)
        {
            Console.Write("Enter your monthly Salary: ");
            string salaryInput = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(salaryInput, out salary))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a numerical value.");
            }
        }

        
        while (true)
        {
            Console.Write("Enter your credit score (0-500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Credit Score must be between 0 and 500.");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a numerical value between 0 and 500.");
            }
        }

       
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (input == "true" || input == "false")
            {
                criminalRecord = Convert.ToBoolean(input);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type 'true' or 'false'.");
            }
        }

       
        CultureInfo bdCulture = new CultureInfo("bn-BD");
        Console.WriteLine("\nLoan Calculator (BDT)");

        Console.Write("Enter Loan Amount (BDT): ");
        string loanInput = (Console.ReadLine() ?? string.Empty).Trim();
        double loanamount = double.Parse(loanInput);

        if (loanamount > (2 * salary))
        {
            Console.WriteLine("Loan amount exceeds twice your salary. Loan not approved.");
            return;
        }

        double principal = loanamount;

        Console.Write("Enter Annual Interest Rate (%): ");
        double annualInterestRate = Convert.ToDouble(Console.ReadLine());
        annualInterestRate = annualInterestRate / 100;

        Console.Write("Enter Loan Duration (in Months): ");
        int months = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualInterestRate / 12;
        double monthlyPayment = (principal * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -months));
        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - principal;

        Console.WriteLine("\nMortgage Summary");
        Console.WriteLine($"Salary: {salary.ToString("C", bdCulture)}");
        Console.WriteLine($"Credit Score: {creditScore}");
        Console.WriteLine($"Criminal Record: {criminalRecord}");
        Console.WriteLine($"Loan Amount: {principal.ToString("C", bdCulture)}");
        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}
