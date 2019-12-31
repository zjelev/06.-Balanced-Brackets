using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Students2_0
    {
        static void Main()
        {
            string command;

            List<Student> students = new List<Student>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ');

                string firstName = input[0];
                string lastName = input[1];

                int existingStudentOn = studentExistsOnIndex(students, firstName, lastName);

                if (existingStudentOn > -1)
                {
                    students[existingStudentOn].FirstName = firstName;
                    students[existingStudentOn].LastName = lastName;
                    students[existingStudentOn].Age = int.Parse(input[2]);
                    students[existingStudentOn].HomeTown = input[3];

                }
                else
                {
                    Student newStudent = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = int.Parse(input[2]),
                        HomeTown = input[3]

                    };

                    students.Add(newStudent);
                }
                
            }

            string homeTown = Console.ReadLine();

            foreach (var item in students)
            {
                if (item.HomeTown == homeTown)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}" +
                        $" is {item.Age} years old.");
                }
            }
        }

        private static int studentExistsOnIndex(List<Student> students, string firstName, string lastname)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (firstName == students[i].FirstName && lastname == students[i].LastName)
                {
                    return i;
                }
            }

            return -1;
        }
    }

}
