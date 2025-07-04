using System.Collections.Generic;
using System.Diagnostics;

namespace _04._Students;
internal class Program
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string GetString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    static void Main(string[] args)
    {
            List<Student> students = new List<Student>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] studentsAsString = Console.ReadLine().Split();

                Student newStudent = new Student(studentsAsString[0],
                    studentsAsString[1],
                    double.Parse(studentsAsString[2]));

                students.Add(newStudent);

            }
            var orderedStudent = students
                .OrderByDescending(s => s.Grade)
                .ToList();
                foreach (Student student in orderedStudent)
                {
                    Console.WriteLine(student.GetString());
                }
     }
}
