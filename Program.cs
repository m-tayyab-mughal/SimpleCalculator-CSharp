using System;

class Program
{
    static void Main()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("1 = Sum");
            Console.WriteLine("2 = Subtraction");
            Console.WriteLine("3 = Multiplication");
            Console.WriteLine("4 = Division");
            Console.WriteLine("5 = Modulus");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("Please select an operation by entering the corresponding number (0-5):");

            // Safe input for choice
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number from 0 to 5.");
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            if (choice < 0 || choice > 5)
            {
                Console.WriteLine("Invalid choice! Please enter a number from 0 to 5.");
                continue;
            }

            // Safe input for first number
            Console.WriteLine("Please enter 1st number:");
            int a;
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            // Safe input for second number
            Console.WriteLine("Please enter 2nd number:");
            int b;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            int result = 0;

            switch (choice)
            {
                case 1:
                    result = ADD(a, b);
                    Console.WriteLine($"The sum of {a} and {b} is {result}.");
                    break;
                case 2:
                    result = SUB(a, b);
                    Console.WriteLine($"The subtraction of {a} and {b} is {result}.");
                    break;
                case 3:
                    result = MUL(a, b);
                    Console.WriteLine($"The multiplication of {a} and {b} is {result}.");
                    break;
                case 4:
                    result = DIV(a, b);
                    if (b != 0)
                        Console.WriteLine($"The division of {a} and {b} is {result}.");
                    break;
                case 5:
                    result = MOD(a, b);
                    if (b != 0)
                        Console.WriteLine($"The modulus of {a} and {b} is {result}.");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 0 to 5.");
                    break;
            }

            Console.WriteLine(); // Blank line for better readability

        } while (true);
    }

    static int ADD(int a, int b)
    {
        return a + b;
    }

    static int SUB(int a, int b)
    {
        return a - b;
    }

    static int MUL(int a, int b)
    {
        return a * b;
    }

    static int DIV(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    static int MOD(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Modulus by zero is not allowed.");
            return 0;
        }
        return a % b;
    }
}
