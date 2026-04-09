using System;
using System.Diagnostics;
using System.IO;

namespace AsyncDemo
{
    internal class Prblm5
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener("OrderLog.txt"));
            Trace.AutoFlush = true;
            Console.WriteLine("Order Processing Started\n");

            try
            {
                ValidateOrder();
                ProcessPayment();
                UpdateInventory();
                GenerateInvoice();

                Trace.TraceInformation("Order processed successfully");
                Console.WriteLine("Order Completed Successfully");
            }
            catch (Exception ex)
            {
                Trace.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine("Order Failed. Check logs");
            }

            Console.WriteLine("\nTrace log saved to OrderLog.txt");
        }

        static void ValidateOrder()
        {
            Trace.WriteLine("Step 1: Validating Order");
            Console.WriteLine("Validating Order");
        }

        static void ProcessPayment()
        {
            Trace.WriteLine("Step 2: Processing Payment");
            Console.WriteLine("Processing Payment");

        }
        static void UpdateInventory()
        {
            Trace.WriteLine("Step 3: Updating Inventory");
            Console.WriteLine("Updating Inventory");
        }
        static void GenerateInvoice()
        {
            Trace.WriteLine("Step 4: Generating Invoice");
            Console.WriteLine("Generating Invoice");
        }
    }
}