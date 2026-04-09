using System;

namespace OOPDemo
{
    class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative");
            }
        }

        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05); 
        }
    }

    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15); 
        }
    }

    internal class OnlineShopping
    {
        static void Main(string[] args)
        {
            Product electronics = new Electronics();
            electronics.Name = "Laptop";
            electronics.Price = 20000;
            double finalPrice = electronics.CalculateDiscount();
            Console.WriteLine("Final Price after 5% discount = " + finalPrice);
        }
    }
}