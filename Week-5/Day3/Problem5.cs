using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem5
    {
        static void Main()
        {
            Product product = new Product();
            var result = product.GetProducts().OrderBy(p => p.ProMrp).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.ReadLine();
        }
    }
}
