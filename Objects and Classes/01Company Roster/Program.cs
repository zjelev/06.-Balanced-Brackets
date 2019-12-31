using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Company_Roster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            int countEmpl = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            for (int i = 0; i < countEmpl; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string dpment = input[2];

                Employee employee = new Employee(input[0], double.Parse(input[1]), dpment);

                employees.Add(employee);

                int departmentExistsOnIndex = -1;

                for (int j = 0; j < departments.Count; j++)
                {
                    if (departments[j].Name == employees[i].Department)
                    {
                        departmentExistsOnIndex = j;
                    }
                }

                if (departmentExistsOnIndex == -1)
                {
                    Department department = new Department(employees[i].Department, employees[i].Salary, 1);
                    departments.Add(department);
                }
                else
                {
                    departments[departmentExistsOnIndex].TotalSalaries += employees[i].Salary;
                    departments[departmentExistsOnIndex].NumOfEmployees++;
                }
            }

            double highestAvgSalary = double.MinValue;
            string dptWithHighestSalary = String.Empty;

            for (int i = 0; i < departments.Count; i++)        
            {
                double avgSalary = departments[i].TotalSalaries / departments[i].NumOfEmployees;
                if (avgSalary > highestAvgSalary)
                {
                    highestAvgSalary = avgSalary;
                    dptWithHighestSalary = departments[i].Name;
                }
            }

            Console.WriteLine($"Highest Average Salary: {dptWithHighestSalary}");

            List<Employee> tarikati = employees.Where(x => x.Department == dptWithHighestSalary).ToList();

            tarikati = tarikati.OrderByDescending(x => x.Salary).ToList();

            tarikati.ForEach(x => Console.WriteLine(x));
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }

    class Department
    {
        public string Name { get; set; }

        public double TotalSalaries { get; set; }

        public int NumOfEmployees { get; set; }

        public Department(string name, double totalSalaries, int numOfEmployees)
        {
            this.Name = name;
            this.TotalSalaries = totalSalaries;
            this.NumOfEmployees = numOfEmployees;
        }
    }
}
