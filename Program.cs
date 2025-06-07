using System;

class Program
{
    // Addition Function
    static int ADD(int a, int b)
    {
        return a + b;
    }

    // Subtraction Function
    static int SUB(int a, int b)
    {
        return a - b;
    }

    // Multiplication Function
    static int MUL(int a, int b)
    {
        return a * b;
    }

    // Division Function
    static int DIV(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    // Modulus Function
    static int MOD(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Modulus by zero is not allowed.");
            return 0;
        }
        return a % b;
    }

    static void Main()
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("1 = Sum");
        Console.WriteLine("2 = Subtraction");
        Console.WriteLine("3 = Multiplication");
        Console.WriteLine("4 = Division");
        Console.WriteLine("5 = Modulus");
        Console.WriteLine("Please select an operation by entering the corresponding number (1-5):");

        // Read user operation
        int num = int.Parse(Console.ReadLine()!);
        int a, b, result;

        switch (num)
        {
            case 1:
                Console.WriteLine("You selected Sum.");
                Console.WriteLine("Enter 1st number:");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter 2nd number:");
                b = int.Parse(Console.ReadLine()!);
                result = ADD(a, b);
                Console.WriteLine($"The sum of {a} and {b} is {result}.");
                break;

            case 2:
                Console.WriteLine("You selected Subtraction.");
                Console.WriteLine("Enter 1st number:");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter 2nd number:");
                b = int.Parse(Console.ReadLine()!);
                result = SUB(a, b);
                Console.WriteLine($"The result of subtracting {b} from {a} is {result}.");
                break;

            case 3:
                Console.WriteLine("You selected Multiplication.");
                Console.WriteLine("Enter 1st number:");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter 2nd number:");
                b = int.Parse(Console.ReadLine()!);
                result = MUL(a, b);
                Console.WriteLine($"The product of {a} and {b} is {result}.");
                break;

            case 4:
                Console.WriteLine("You selected Division.");
                Console.WriteLine("Enter 1st number:");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter 2nd number:");
                b = int.Parse(Console.ReadLine()!);
                result = DIV(a, b);
                Console.WriteLine($"The result of dividing {a} by {b} is {result}.");
                break;

            case 5:
                Console.WriteLine("You selected Modulus.");
                Console.WriteLine("Enter 1st number:");
                a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter 2nd number:");
                b = int.Parse(Console.ReadLine()!);
                result = MOD(a, b);
                Console.WriteLine($"The modulus of {a} % {b} is {result}.");
                break;

            default:
                Console.WriteLine("Invalid selection. Please enter a number from 1 to 5.");
                break;
        }
    }
}
