using System;

namespace OOPDemo
{
    internal class Vehicle
    {
        private string brand;
        private double rentalRatePerDay;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double RentalRatePerDay
        {
            get { return rentalRatePerDay; }
            set { rentalRatePerDay = value; }
        }

        public virtual double CalculateRental(int days)
        {
            return rentalRatePerDay * days;
        }

        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.RentalRatePerDay = 2000;

            int days = 3;

            Console.WriteLine("Total Rental = " + car.CalculateRental(days));
        }
    }

    class Car : Vehicle
    {
        public override double CalculateRental(int days)
        {
            return base.CalculateRental(days) + 500;
        }
    }

    class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            double total = base.CalculateRental(days);
            return total - (total * 0.05);
        }
    }
}