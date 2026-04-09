using System;

namespace oopsDesignDemo.OCP
{
    internal class RegularCustomerDiscount:IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }
    }
}
