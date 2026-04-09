using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem11
    {
        static void Main()
        {
            Product product = new Product();
            var count = product.GetProducts().Count(p => p.ProCategory == "FMCG");

            Console.WriteLine("FMCG Products Count: " + count);

            Console.ReadLine();
        }
    }
}
