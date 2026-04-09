using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem7
    {
        static void Main()
        {
            Product product = new Product();
            var result = product.GetProducts().GroupBy(p => p.ProCategory);
            foreach (var group in result)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
                }
            }

            Console.ReadLine();
        }
    }
}
