using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first number:");
     
        int n1 = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Enter the second number:");
        
        int n2 = Convert.ToInt32(Console.ReadLine());
       
        int result = n1 + n2;

      
        Console.WriteLine("The sum is: " + result);
    }
}