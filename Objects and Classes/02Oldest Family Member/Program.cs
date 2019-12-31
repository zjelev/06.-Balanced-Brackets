using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Oldest_Family_Member
{
    class OldestFamilyMember
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }

    class Family
    {
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Family()
        {
            this.People = new List<Person>();
        }
    }
}