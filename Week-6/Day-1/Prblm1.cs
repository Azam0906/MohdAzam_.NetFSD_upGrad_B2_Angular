using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Prblm1
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Application Started...\n");
            Task t1 = WriteLogAsync("User logged in");
            Task t2 = WriteLogAsync("File uploaded");
            Task t3 = WriteLogAsync("Error occurred");
            Task t4 = WriteLogAsync("User logged out");

            Console.WriteLine("Main thread is free while logging \n");
            await Task.WhenAll(t1, t2, t3, t4);
            Console.WriteLine("\nAll logs completed!");
        }

        static async Task WriteLogAsync(string message)
        {
            Console.WriteLine($"Start: {message}");
            await Task.Delay(2000);
            Console.WriteLine($"End: {message}");
        }
    }
}