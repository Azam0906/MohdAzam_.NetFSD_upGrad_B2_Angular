using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Experience (years): ");
        int experience = Convert.ToInt32(Console.ReadLine());

        double bonus = 0;

        if (experience < 2)
        {
            bonus = salary * 0.05;
        }
        else if (experience >= 2 && experience <= 5)
        {
            bonus = salary * 0.10;
        }
        else
        {
            bonus = salary * 0.15;
        }

        // using ternary operator for final salary
        double finalSalary = bonus > 0 ? salary + bonus : salary;

        Console.WriteLine();
        Console.WriteLine("Employee: " + name);
        Console.WriteLine("Bonus: " + bonus.ToString("F2"));
        Console.WriteLine("Final Salary: " + finalSalary.ToString("F2"));
    }
}