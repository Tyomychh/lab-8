using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "employees.txt";

        List<Employee> employees = new List<Employee>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int experience = int.Parse(parts[1]);
                int salary = int.Parse(parts[2]);
                employees.Add(new Employee(name, experience, salary));
            }
        }

        employees = employees.OrderBy(e => e.Salary).ToList();

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - Experience: {employee.Experience}, Salary: {employee.Salary}");
        }
    }
}


class Employee
{
    public string Name { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int experience, int salary)
    {
        Name = name;
        Experience = experience;
        Salary = salary;
    }
}