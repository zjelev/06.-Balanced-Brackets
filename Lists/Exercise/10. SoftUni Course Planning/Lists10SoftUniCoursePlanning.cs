using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":");
                string command = commands[0];
                string lesson = commands[1];
                string exercise = "{0}-Exercise";
                string firstExercise = string.Format(exercise, lesson);

                switch (command)
                {
                    case "Add":
                        if (!schedule.Contains(lesson))
                        {
                            schedule.Add(lesson);
                        }
                        break;
                    case "Insert":
                        if (!schedule.Contains(lesson))
                        {
                            schedule.Insert(int.Parse(commands[2]), lesson);
                        }
                        break;
                    case "Remove":
                        if (schedule.Contains(lesson))
                        {
                            schedule.Remove(lesson);
                        }
                        
                        if (schedule.Contains(firstExercise))
                        {
                            schedule.Remove(firstExercise);
                        }
                        break;
                    case "Swap":
                        string secondLesson = commands[2];
                        if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                        {
                            string secondExercise = string.Format(exercise, secondLesson);

                            Swap(schedule, lesson, secondLesson);

                            if (schedule.Contains(firstExercise))
                            {
                                int indexOfLesson = schedule.IndexOf(lesson);
                                schedule.Remove(firstExercise);
                                schedule.Insert(indexOfLesson + 1, firstExercise);
                            }

                            if (schedule.Contains(secondExercise))
                            {
                                int indexOfLesson = schedule.IndexOf(secondLesson);
                                schedule.Remove(secondExercise);
                                schedule.Insert(indexOfLesson + 1, secondExercise);
                            }  
                        }
                        break;
                    case "Exercise":
                        if (!schedule.Contains(firstExercise))
                        {
                            if (schedule.Contains(lesson))
                            {
                                int indexLesson = schedule.IndexOf(lesson);
                                schedule.Insert(indexLesson + 1, firstExercise);
                            }
                            else
                            {
                                schedule.Add(lesson);
                                schedule.Add(firstExercise);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
        }

        private static void Swap(List<string> arr, string first, string second)
        {
            int firstIndex = arr.IndexOf(first);
            int secondIndex = arr.IndexOf(second);

            arr[firstIndex] = second;
            arr[secondIndex] = first;
        }
    }
}