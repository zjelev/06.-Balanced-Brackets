using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(student);
            }

            students = students.OrderByDescending(a => a.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public double Grade { get; set; }

        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
    }
}
