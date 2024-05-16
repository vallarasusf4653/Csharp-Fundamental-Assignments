using System;
namespace Encapsulation;
public class Program 
{
    public static void Main(string[] args)
    {
      StudentDetails student = new StudentDetails();
      student.StudentName="Vallarasu";
      student.Age=22;
     Console.WriteLine(student.StudentName +" "+student.Age);
     student.Show();
       
    }
}