using System;

public class Student
{
    public double CalculateAverage(int m1, int m2, int m3)
    {
        double avg = (m1 + m2 + m3) / 3.0;
        return avg;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.Write("Enter marks 1: ");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks 2: ");
        int m2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks 3: ");
        int m3 = Convert.ToInt32(Console.ReadLine());

        double average = s.CalculateAverage(m1, m2, m3);

        char grade;

        if (average >= 80)
            grade = 'A';
        else if (average >= 60)
            grade = 'B';
        else if (average >= 40)
            grade = 'C';
        else
            grade = 'F';

        Console.WriteLine("Average = " + average);
        Console.WriteLine("Grade = " + grade);
    }
}