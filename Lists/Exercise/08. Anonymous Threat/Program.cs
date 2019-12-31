using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> line = Console.ReadLine()
                .Split(" ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commands = input.Split(" ");
                string firstComm = commands[0];

                if (firstComm == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= line.Count)
                    {
                        endIndex = line.Count - 1;
                    }

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        line[startIndex] += line[startIndex + 1];
                        line.RemoveAt(startIndex + 1);
                    }

                }
                else if (firstComm == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    if (partitions > 1)
                    {
                        List<char> element = line[index].ToList();

                        line.RemoveAt(index);

                        int partitionSize = element.Count / partitions;

                        string dividedPartition = String.Empty;
                        int countPartitionSize = 0;

                        List<string> partitionsToInsert = new List<string>();

                        for (int i = 0; i < element.Count; i++)
                        {
                            dividedPartition += element[i];
                            element.RemoveAt(i);
                            i--;
                            countPartitionSize++;

                            if (countPartitionSize == partitionSize)
                            {
                                partitionsToInsert.Add(dividedPartition);
                                countPartitionSize = 0;
                                dividedPartition = String.Empty;
                                partitions--;
                            }

                            if (partitions == 1)
                            {
                                partitionsToInsert.Add(string.Join("", element));
                                break;
                            }
                        }

                        line.InsertRange(index, partitionsToInsert);
                    }

                }
            }

            Console.WriteLine(string.Join(" ", line));
        }
    }
}