using System;


namespace oopsDesignDemo.SRP
{
    internal class Program
    {
        static void Main()
        {
            StudentRepository repo = new StudentRepository();

            repo.AddStudent(new Student { StudentId = 1, StudentName = "Ajay", Marks = 85 });
            repo.AddStudent(new Student { StudentId = 2, StudentName = "Rahul", Marks = 90 });
            ReportGenerator report = new ReportGenerator();
            report.GenerateReport(repo.GetAllStudents());
        }
    }
}
