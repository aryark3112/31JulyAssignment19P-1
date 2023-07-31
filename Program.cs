using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31JulyAssignment19P_1
{
     class Program
    {
      

// Step 1: Create the delegate
delegate int ArithmeticOperation(int a, int b);

    
        // Step 2: Implement the methods for arithmetic operations
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return a / b;
        }

        static void Main(string[] args)
        {
            // Step 3: Create instances of the ArithmeticOperation delegate for each method
            ArithmeticOperation addOperation = Add;
            ArithmeticOperation subtractOperation = Subtract;
            ArithmeticOperation multiplyOperation = Multiply;
            ArithmeticOperation divideOperation = Divide;

            // Step 4: Ask the user to input two integers
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Step 5: Prompt the user to choose an arithmetic operation
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = int.Parse(Console.ReadLine());

            // Step 6: Call the corresponding method through the delegate and display the result
            int result;
            switch (choice)
            {
                case 1:
                    result = addOperation(num1, num2);
                    Console.WriteLine($"Result of addition: {result}");
                    break;
                case 2:
                    result = subtractOperation(num1, num2);
                    Console.WriteLine($"Result of subtraction: {result}");
                    break;
                case 3:
                    result = multiplyOperation(num1, num2);
                    Console.WriteLine($"Result of multiplication: {result}");
                    break;
                case 4:
                    try
                    {
                        result = divideOperation(num1, num2);
                        Console.WriteLine($"Result of division: {result}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();
        }
    }

}

