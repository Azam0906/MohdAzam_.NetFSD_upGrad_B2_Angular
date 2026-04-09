using System;

namespace StudentRecordSystem
{
    public record Student(int RollNumber, string Name, string Course, int Marks);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Enter a valid number: ");
            }

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                int roll;
                Console.Write("Enter Roll Number: ");
                while (!int.TryParse(Console.ReadLine(), out roll) || roll <= 0)
                {
                    Console.Write("Invalid Roll Number. Enter again: ");
                }

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                int marks;
                Console.Write("Enter Marks: ");
                while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
                {
                    Console.Write("Invalid Marks (0-100). Enter again: ");
                }

                students[i] = new Student(roll, name, course, marks);
            }

            int choice;
            do
            {
                Console.WriteLine("\n MENU ");
                Console.WriteLine("1. Display All Students");
                Console.WriteLine("2. Search Student by Roll Number");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid choice. Enter again: ");
                }

                switch (choice)
                {
                    case 1:
                        DisplayStudents(students);
                        break;

                    case 2:
                        Console.Write("Enter Roll Number to search: ");
                        int searchRoll;

                        while (!int.TryParse(Console.ReadLine(), out searchRoll))
                        {
                            Console.Write("Invalid input. Enter again: ");
                        }

                        SearchStudent(students, searchRoll);
                        break;

                    case 3:
                        Console.WriteLine("Exiting program");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 3);
        }

        static void DisplayStudents(Student[] students)
        {
            Console.WriteLine("\nStudent Records:");
            foreach (var s in students)
            {
                Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
            }
        }

        static void SearchStudent(Student[] students, int rollNumber)
        {
            bool found = false;

            foreach (var s in students)
            {
                if (s.RollNumber == rollNumber)
                {
                    Console.WriteLine("\nStudent Found:");
                    Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nStudent record not found!");
            }
        }
    }
}