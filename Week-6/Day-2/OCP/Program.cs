using System;

namespace oopsDesignDemo.OCP
{
    internal class Program
    {
        static void Main()
        {
            double amount = 1000;
            IDiscountStrategy discount = new VipCustomerDiscount();
            PriceCalculator calculator = new PriceCalculator(discount);
            double finalPrice = calculator.CalculateFinalPrice(amount);
            Console.WriteLine($"Final Price: {finalPrice}");
        }
    }
}
