using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem14
    {
        static void Main()
        {
            Product product = new Product();
            var result = product.GetProducts().All(p => p.ProMrp < 30);

            Console.WriteLine("All products below Rs.30: " + result);
            Console.ReadLine();
        }
    }
}
