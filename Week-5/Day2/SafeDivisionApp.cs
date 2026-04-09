using System;

namespace SafeDivisionApp
{
    class Calculator
    {
        public void Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
            finally
            {
                Console.WriteLine("Operation completed safely");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            while (true)
            {
                try
                {
                    Console.Write("Enter Numerator: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Enter Denominator: ");
                    int den = int.Parse(Console.ReadLine());
                    calc.Divide(num, den);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter integers only");
                }

                Console.Write("Do you want to continue? (y/n): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "y")
                    break;
            }
        }
    }
}