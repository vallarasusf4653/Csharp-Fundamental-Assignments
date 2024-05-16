using System;
namespace Classes;
public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("vallarasu", 22, "Software Engineer");
        Console.WriteLine($"Name : {student1.Name}");
        Console.WriteLine(student1.StudentInfo());
        student1.StudentInfo("vallarasu");
        Console.WriteLine();
        Console.WriteLine();

        Student student2 = new Student("Tamil", 23, "UI Developer");
        Console.WriteLine($"Name : {student2.Name}");
        Console.WriteLine(student2.StudentInfo());


    }
}