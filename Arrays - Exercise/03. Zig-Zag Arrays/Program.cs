using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] flyingField = new int[fieldSize];

            int[] bugsPositions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //place the bugs on the field
            for (int i = 0; i < bugsPositions.Length; i++)
            {
                flyingField[bugsPositions[i]] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToFly = command.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int bugInitialIndex = int.Parse(commandToFly[0]);
                string direction = commandToFly[1];
                int indexesToFly = int.Parse(commandToFly[2]);

                if (flyingField[bugInitialIndex] == 1)
                {
                    flyingField[bugInitialIndex] = 0;

                    if (direction == "right")
                    {
                        if (bugInitialIndex + indexesToFly < flyingField.Length && bugInitialIndex + indexesToFly >= 0)
                        {
                            if (flyingField[bugInitialIndex + indexesToFly] == 0)
                            {
                                flyingField[bugInitialIndex + indexesToFly] = 1;
                            }
                            else
                            {
                                indexesToFly += indexesToFly;
                            }
                        }
                    }
                    else
                    {
                        if (bugInitialIndex - indexesToFly < flyingField.Length && bugInitialIndex - indexesToFly >= 0)
                        {
                            if (flyingField[bugInitialIndex - indexesToFly] == 0)
                            {
                                flyingField[bugInitialIndex - indexesToFly] = 1;
                            }
                            else
                            {
                                indexesToFly += indexesToFly;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", flyingField));
        }
    }
}