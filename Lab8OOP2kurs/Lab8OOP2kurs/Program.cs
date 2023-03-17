using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var students = File.ReadAllLines("students.txt")
        .Select(line => line.Split(','))
        .Select(fields => new Student
        {
            Name = fields[0],
            Grade1 = int.Parse(fields[1]),
            Grade2 = int.Parse(fields[2]),
            Grade3 = int.Parse(fields[3])
        })
        .ToArray();

        Console.WriteLine("Усi студенти:");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}, {student.Grade1}, {student.Grade2}, {student.Grade3}");
        }

        var filteredStudents = students.Where(student => student.AverageGrade >= 80).ToArray();

        Console.WriteLine("\nФiльтр студентiв (Середня оцiнка >= 80):");

        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"{student.Name}, {student.Grade1}, {student.Grade2}, {student.Grade3}, Середня оцiнка: {student.AverageGrade}");
        }

        Console.ReadKey();
    }
}

class Student
{
    public string Name { get; set; }
    public int Grade1 { get; set; }
    public int Grade2 { get; set; }
    public int Grade3 { get; set; }

    public double AverageGrade => (Grade1 + Grade2 + Grade3) / 3.0;
}