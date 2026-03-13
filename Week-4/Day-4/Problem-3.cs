using System;

class ResultAnalyzer
{
    public static void CalculateResult(int m1, int m2, int m3, out int totalMarks, out double averageMarks)
    {
        totalMarks = m1 + m2 + m3;
        averageMarks = totalMarks / 3.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks for Subject 1: ");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        int m2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        int m3 = Convert.ToInt32(Console.ReadLine());

        if (m1 < 0 || m1 > 100 || m2 < 0 || m2 > 100 || m3 < 0 || m3 > 100)
        {
            Console.WriteLine("Marks must be between 0 and 100.");
            return;
        }

        int total;
        double average;

        ResultAnalyzer.CalculateResult(m1, m2, m3, out total, out average);

        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);

        if (average >= 40)
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");
    }
}