using System;
using System.Collections.Generic;
enum AcademicStanding
{
    Freshman, Sophomore, Junior, Senior
}
class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public AcademicStanding Year {get; set; }
    public Student(string name, int id, AcademicStanding year)
    {
        Name = name;
        ID = id;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("---Student Information---\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student ID: " + ID);
        Console.WriteLine("Academic Level: " + Year + "\n");
        Console.ResetColor();
    }
}
class AcademicLevel
{
    static void Main()
    {
        List<Student> students = new  List<Student>
        {
            new Student("Maksud", 22103265, AcademicStanding.Senior),
            new Student("Abdullah", 23103265, AcademicStanding.Junior),
            new Student("Alex", 26103265, AcademicStanding.Freshman),
            new Student("Rakib", 25103265, AcademicStanding.Sophomore),
        };
        foreach (var s in students)
        {
            s.DisplayInfo();
        }
    }
}