using System;

namespace EmployeePerformance
{
    internal class Prblm3
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Monthly Sales Amount:");
            double sales = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Customer Rating (1-5):");
            int rating = Convert.ToInt32(Console.ReadLine());

            try
            {
                var result = GetEmployeeData(sales, rating);
                string performance = result switch
                {
                    ( >= 100000, >= 4) => "High Performer",
                    ( >= 50000, >= 3) => "Average Performer",
                    _ => "Needs Improvement"
                };
                Console.WriteLine("\nEmployee Name: " + name);
                Console.WriteLine("Sales Amount: " + result.sales);
                Console.WriteLine("Rating: " + result.rating);
                Console.WriteLine("Performance: " + performance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static (double sales, int rating) GetEmployeeData(double sales, int rating)
        {
            return (sales, rating);
        }
    }
}