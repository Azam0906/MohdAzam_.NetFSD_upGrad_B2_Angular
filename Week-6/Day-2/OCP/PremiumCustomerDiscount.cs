using System;


namespace oopsDesignDemo.OCP
{
    internal class PremiumCustomerDiscount: IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.10; 
        }
    }
}
