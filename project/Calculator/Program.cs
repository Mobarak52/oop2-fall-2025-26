using System;

string again;

do
{
    Console.WriteLine("Working Calculator");
    Console.WriteLine("1. Add +");
    Console.WriteLine("2. Subtract -");
    Console.WriteLine("3. Multiply *");
    Console.WriteLine("4. Divide /");
    Console.Write("Enter a number (1-4): ");

    int c;
    while (!int.TryParse(Console.ReadLine(), out c) || c < 1 || c > 4)
    {
        Console.Write("Invalid choice! Enter any number (1-4): ");
    }

    Console.Write("Enter the first number: ");
    double num1;
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Invalid number! Try again: ");
    }

    Console.Write("Enter the second number: ");
    double num2;
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Invalid number! Try again: ");
    }

    double result = 0;
    string operation = "";

    switch (c)
    {
        case 1:
            result = num1 + num2;
            operation = "+";
            break;
        case 2:
            result = num1 - num2;
            operation = "-";
            break;
        case 3:
            result = num1 * num2;
            operation = "*";
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            else
            {
                result = num1 / num2;
                operation = "/";
            }
            break;
    }

    if (c != 4 || num2 != 0)
        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

    Console.Write("\nDo you want to calculate again? (y/n): ");
    again = Console.ReadLine().ToLower();

    while (again != "y" && again != "n")
    {
        Console.Write("Please type 'y' for yes or 'n' for no: ");
        again = Console.ReadLine().ToLower();
    }

} while (again == "y");

Console.WriteLine("Goodbye!");
