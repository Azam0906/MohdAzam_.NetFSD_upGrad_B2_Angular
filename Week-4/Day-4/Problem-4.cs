using System;

class OrderCalculator
{
    public static double CalculateFinalAmount(double price, int quantity, double discount = 0, double shipping = 50)
    {
        double subtotal = price * quantity;

        double discountAmount = subtotal * (discount / 100);

        double amountAfterDiscount = subtotal - discountAmount;

        double finalAmount = amountAfterDiscount + shipping;

        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Discount Applied: " + discountAmount);

        return finalAmount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        double final = OrderCalculator.CalculateFinalAmount(price, qty);

        Console.WriteLine("Final Amount: " + final);
    }
}