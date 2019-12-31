using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            List<int> distToPokemons = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            int sum = 0;
            //int j = 1;

            while (distToPokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedValue;

                if (index < 0)
                {
                    removedValue = distToPokemons[0];
                    distToPokemons.RemoveAt(0);
                    distToPokemons.Insert(0, distToPokemons[distToPokemons.Count - 1]);
                }
                else if (index >= distToPokemons.Count)
                {
                    removedValue = distToPokemons[distToPokemons.Count - 1];
                    distToPokemons.RemoveAt(distToPokemons.Count - 1);
                    distToPokemons.Add(distToPokemons[0]);
                }
                else
                {
                    removedValue = distToPokemons[index];
                    distToPokemons.RemoveAt(index);
                }
                                
                for (int i = 0; i < distToPokemons.Count; i++)
                {
                    if (distToPokemons[i] <= removedValue)
                    {
                        distToPokemons[i] += removedValue;
                    }
                    else
                    {
                        distToPokemons[i] -= removedValue;
                    }
                }
                sum += removedValue;

                //Console.WriteLine($"Step {j}: {string.Join(", ", distToPokemons)}");
                //Console.WriteLine($"Sum: {sum}");
                //j++;
            }

            Console.WriteLine(sum);
        }
    }
}
