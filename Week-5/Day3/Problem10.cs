using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem10
    {
        static void Main()
        {
            Product product = new Product();
            var count = product.GetProducts().Count();

            Console.WriteLine("Total Products: " + count);
            Console.ReadLine();
        }
    }
}
