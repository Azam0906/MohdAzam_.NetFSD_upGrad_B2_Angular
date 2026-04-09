using System;

namespace oopsDesignDemo.RepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentRepository();
            StudentService service = new StudentService(repo);
            
            service.AddStudent(new Student { StudentId = 1, StudentName = "Ajay", Course = "Java" });
            service.AddStudent(new Student { StudentId = 2, StudentName = "Ravi", Course = "Python" });

            Console.WriteLine("All Students:");
            service.DisplayStudents();

            Console.WriteLine("\nSearch Student ID 1:");
            service.FindStudent(1);

            Console.WriteLine("\nDeleting Student ID 2");
            service.DeleteStudent(2);

            Console.WriteLine("\nAfter Deletion:");
            service.DisplayStudents();
        }
    }
}
