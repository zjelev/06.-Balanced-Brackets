using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ");
            var studentCourses = new Dictionary<string, string>();
            while (input[0] != "end")
            {
                string course = input[0];
                string student = input[1];

                if (!studentCourses.ContainsKey(student))
                {
                    studentCourses[student] = course;
                }

                input = Console.ReadLine().Split(" : ");
            }

            var courses = new Dictionary<string, int>();

            foreach (var kvp in studentCourses)
            {
                if (!courses.ContainsKey(kvp.Value))
                {
                    courses[kvp.Value] = 0;
                }

                courses[kvp.Value]++;
            }

            courses = courses
            .OrderByDescending(x => x.Value)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            studentCourses = studentCourses
            .OrderBy(x => x.Key)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                Console.WriteLine(string.Join(Environment.NewLine, studentCourses
                .Where(x => x.Value == kvp.Key)
                .Select(x => $"-- {x.Key}")));  
            }
        }
    }
}
