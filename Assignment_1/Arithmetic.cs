using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public delegate void Operation(int a, int b);

    internal class Arithmetic
    {
        public void AddNumbers(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"\nSum of {a} and {b} is:"+result);
        }

        // Method to multiply two numbers and print the result
        public void MultiplyNumbers(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"\nProduct of {a} and {b} is:"+result);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Arithmetic a1 = new Arithmetic();

            // Create a delegate reference of type Operation
            Operation operation = null;

            // Accept two numbers from the user
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Accept a choice from the user
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Both");
            int ch = Convert.ToInt32(Console.ReadLine());

            // Add appropriate method(s) to the delegate based on user choice
            switch (ch)
            {
                case 1:
                    operation = new Operation(a1.AddNumbers);
                    break;
                case 2:
                    operation = new Operation(a1.MultiplyNumbers);
                    break;
                case 3:
                    operation = new Operation(a1.AddNumbers);
                    operation += new Operation(a1.MultiplyNumbers);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            // Call/invoke the delegate
            operation?.Invoke(num1, num2);

            Console.ReadLine();
            
        }
    }
            
}

