using System;

namespace AsyncDemo
{
    internal class Prblm2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Discount Percentage:");
            double discount = Convert.ToDouble(Console.ReadLine());
            double discountAmount = price * discount / 100;
            double finalPrice = price - discountAmount;

            Console.WriteLine("\n--- Bill Details ---");
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Discount: {discount}%");
            Console.WriteLine($"Final Price: {finalPrice}");
        }
    }
}