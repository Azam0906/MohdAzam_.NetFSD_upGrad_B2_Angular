using System;

namespace oopsDesignDemo.LSP
{
    internal class AreaCalculator
    {
        public static void PrintArea(Shape shape)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
