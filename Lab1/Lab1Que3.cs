lusing System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

       
        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        bool divisionByZero = num2 == 0;
        double quotient = 0;

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        if (!divisionByZero)
        {
            quotient = (double)num1 / num2;
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}