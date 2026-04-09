using System;
using System.Linq;

namespace LinqCodeTemplate
{
    internal class Problem12
    {
        static void Main()
        {
            Product product = new Product();
            var maxPrice = product.GetProducts().Max(p => p.ProMrp);

            Console.WriteLine("Max Price: " + maxPrice);
            Console.ReadLine();
        }
    }
}
