using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem8
    {
        static void Main()
        {
            Product product = new Product();
            var result = product.GetProducts().GroupBy(p => p.ProMrp);
            foreach (var group in result)
            {
                Console.WriteLine($"\nMRP: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}");
                }
            }

            Console.ReadLine();
        }
    }
}
