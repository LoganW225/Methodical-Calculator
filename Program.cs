using System;

double a, b; // used in operations

while (true)
{
    // Main menu
    Console.WriteLine("\n=== Calculator ===");
    Console.WriteLine("1) Add");
    Console.WriteLine("2) Subtract");
    Console.WriteLine("3) Multiply");
    Console.WriteLine("5) Exit");
    Console.Write("Choose an option (1-5): ");

    string choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
            case "1":
            ReadTwoNumbers(out a, out b);
            Console.WriteLine($"Result: {Add(a, b)}");
            break;

            case "2":
            ReadTwoNumbers(out a, out b);
            Console.WriteLine($"Result: {Subtract(a, b)}");
            break;

        case "3":
            ReadTwoNumbers(out a, out b);
            Console.WriteLine($"Result: {Multiply(a, b)}");
            break;

        case "5":
            Console.WriteLine("Goodbye!");
            return;

            default:
            Console.WriteLine("Invalid menu choice. Please enter 1-5.");
            break;
    }
}

// Operation methods 

double Add(double x, double y) => x + y;

double Subtract(double x, double y) => x - y;

double Multiply(double x, double y) => x * y;

double Divide(double x, double y) => x / y; 

// Input helper

void ReadTwoNumbers(out double x, out double y)
{
    x = ReadNumber("Enter the first number: ");
    y = ReadNumber("Enter the second number: ");
}

double ReadNumber(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (double.TryParse(input, out double value))
            return value;

        Console.WriteLine("Invalid number. Try again.");
    }
}
