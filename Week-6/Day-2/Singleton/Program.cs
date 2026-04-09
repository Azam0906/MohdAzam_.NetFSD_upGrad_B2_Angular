using System;

namespace oopsDesignDemo.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config1 = ConfigurationManager.GetInstance();
            var config2 = ConfigurationManager.GetInstance();

            Console.WriteLine("Config1:");
            Console.WriteLine(config1.ApplicationName);
            Console.WriteLine(config1.Version);
            Console.WriteLine("\nConfig2:");
            Console.WriteLine(config2.ApplicationName);
            Console.WriteLine(config2.Version);

            if (config1 == config2)
            {
                Console.WriteLine("\nSame Instance");
            }
            else
            {
                Console.WriteLine("\nDifferent Instance");
            }
        }
    }
}
