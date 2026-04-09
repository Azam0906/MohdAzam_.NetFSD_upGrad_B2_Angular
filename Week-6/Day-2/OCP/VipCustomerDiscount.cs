using System;


namespace oopsDesignDemo.OCP
{
    internal class VipCustomerDiscount: IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.20;
        }
    }
}
