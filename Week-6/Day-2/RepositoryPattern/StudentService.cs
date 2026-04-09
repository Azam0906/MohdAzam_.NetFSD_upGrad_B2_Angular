using System;

namespace oopsDesignDemo.RepositoryPattern
{
    internal class StudentService
    {
        private IStudentRepository repository;

        public StudentService(IStudentRepository repo)
        {
            repository = repo;
        }

        public void AddStudent(Student student)
        {
            repository.AddStudent(student);
        }

        public void DisplayStudents()
        {
            var students = repository.GetAllStudents();
            foreach (var s in students)
            {
                Console.WriteLine($"{s.StudentId} - {s.StudentName} - {s.Course}");
            }
        }

        public void FindStudent(int id)
        {
            var student = repository.GetStudentById(id);
            if (student != null)
                Console.WriteLine($"Found: {student.StudentName}");
            else
                Console.WriteLine("Student not found");
        }

        public void DeleteStudent(int id)
        {
            repository.DeleteStudent(id);
        }
    }
}
