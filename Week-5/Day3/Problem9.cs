using System;
using System.Linq;


namespace LinqCodeTemplate
{
    internal class Problem9
    {
        static void Main()
        {
            Product product = new Product();

            var result = product.GetProducts().Where(p => p.ProCategory == "FMCG")
                                .OrderByDescending(p => p.ProMrp).FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine($"{result.ProCode}\t{result.ProName}\t{result.ProMrp}");
            }

            Console.ReadLine();
        }
    }
}
