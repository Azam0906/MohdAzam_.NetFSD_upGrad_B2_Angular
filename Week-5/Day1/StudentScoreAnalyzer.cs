using System;
using System.Linq;


namespace ArraysDemo
{
    internal class StudentScoreAnalyzer
    {
        static void Main(string[] args)
        {
            int[] marks = { 78, 85, 90, 67, 88 };
            int threshold = 80;
            int totalMarks = marks.Sum();
            double averageMarks = marks.Average();
            int studentsAbove = marks.Where(m => m > threshold).Count();
            int highestScore = marks.Max();

            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: " + averageMarks);
            Console.WriteLine("Students above 80: " + studentsAbove);
            Console.WriteLine("Highest Score: " + highestScore);
        }
    }
}
