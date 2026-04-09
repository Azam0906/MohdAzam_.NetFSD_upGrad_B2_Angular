using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem13
    {
        static void Main()
        {
            Product product = new Product();
            var minPrice = product.GetProducts().Min(p => p.ProMrp);
            Console.WriteLine("Min Price: " + minPrice);

            Console.ReadLine();
        }
    }
}
