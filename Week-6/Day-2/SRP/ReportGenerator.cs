using System;


namespace oopsDesignDemo.SRP
{
    internal class ReportGenerator
    {
        public void GenerateReport(List<Student> students)
        {
            Console.WriteLine("\n--- Student Report ---");

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Marks: {student.Marks}");
            }
        }
    }
}
