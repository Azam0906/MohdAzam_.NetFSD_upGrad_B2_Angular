using System;


namespace oopsDesignDemo.OCP
{
    internal interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
}
