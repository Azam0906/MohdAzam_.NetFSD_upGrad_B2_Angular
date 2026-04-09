using System;

namespace OOPDemo
{
    internal class BaseClass
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }

        static void Main(string[] args)
        {
            double baseSalary = 50000;
            BaseClass manager = new Manager();
            manager.BaseSalary = baseSalary;
            BaseClass developer = new Developer();
            developer.BaseSalary = baseSalary;
            Console.WriteLine("Manager Salary = " + manager.CalculateSalary());
            Console.WriteLine("Developer Salary = " + developer.CalculateSalary());
        }
    }

    class Manager : BaseClass
    {
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.20);
        }
    }

    class Developer : BaseClass
    {
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.10);
        }
    }
}
