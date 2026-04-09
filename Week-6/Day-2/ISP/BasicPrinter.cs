using System;

namespace oopsDesignDemo.ISP
{
    class BasicPrinter:IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Basic Printer: Printing document");
        }
    }
}
