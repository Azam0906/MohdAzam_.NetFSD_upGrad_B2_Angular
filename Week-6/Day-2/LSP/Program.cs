using System;

namespace oopsDesignDemo.LSP
{
    internal class Program
    {
        static void Main()
        {
            Shape rect = new Rectangle(10, 5);
            Shape circle = new Circle(7);
            AreaCalculator.PrintArea(rect);   
            AreaCalculator.PrintArea(circle); 
        }
    }
}
