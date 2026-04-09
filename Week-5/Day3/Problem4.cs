using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem4
    {
        static void Main()
        {
            Product product = new Product();
            var result = product.GetProducts().OrderBy(p => p.ProCategory).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCategory}\t{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.ReadLine();
        }
    }
}
