using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> course = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":");
                string command = commands[0];
                string lessonTitle = commands[1];
                string lessonExercise = lessonTitle + "-Exercise";

                switch (command)
                {
                    case "Add":
                        if (!course.Contains(lessonTitle))
                        {
                            course.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        if (!course.Contains(lessonTitle))
                        {
                            course.Insert(int.Parse(commands[2]), lessonTitle);
                        }
                        break;
                    case "Remove":
                        if (course.Contains(lessonTitle))
                        {
                            course.Remove(lessonTitle);
                        }
                        if (course.Contains(lessonExercise))
                        {
                            course.Remove(lessonExercise);
                        }
                        break;
                    case "Swap":
                        string lessonTitleTwo = commands[2];
                        string lessonExerciseTwo = lessonTitleTwo + "-Exercise";

                        if (course.Contains(lessonTitle) && course.Contains(lessonTitleTwo))
                        {
                            Swap(course, lessonTitle, lessonTitleTwo);

                            if (course.Contains(lessonExercise) && course.Contains(lessonExerciseTwo))
                            {
                                Swap(course, lessonTitle, lessonTitleTwo);
                            }
                            else if (course.Contains(lessonExercise) && !course.Contains(lessonExerciseTwo))
                            {
                                int temp = course.IndexOf(lessonTitleTwo);
                                course.Insert(temp, lessonExercise);
                            }
                            else if (course.Contains(lessonExerciseTwo) && course.Contains(lessonExercise))
                            {
                                int temp = course.IndexOf(lessonTitle);
                                course.Insert(temp, lessonExerciseTwo);
                            }
                        }
                        break;
                    case "Exercise":
                        if (course.Contains(lessonTitle) && !course.Contains(lessonExercise))
                        {
                            int temp = course.IndexOf(lessonTitle);
                            course.Insert(temp, lessonExercise);
                        }
                        else if (!course.Contains(lessonTitle))
                        {
                            course.Add(lessonTitle);
                            course.Add(lessonExercise);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Swap(List<string> course, string item1, string item2)
        {
            int temp = course.IndexOf(item1);
            int tempTwo = course.IndexOf(item2);

            course[temp] = item2;
            course[tempTwo] = item1;
        }
    }
}
