using System;
namespace Inheritance;
public class Program
{
    public static void Main(string[] args)
    {
        EmployeeDetails employee = new EmployeeDetails("vallarasu", 22, "Male", "SF4653", "Software Engineer");
        Console.WriteLine($"Employee Name : {employee.Name}");
        Console.WriteLine($"Employee Age : {employee.Age}");
        Console.WriteLine($"Employee Gender : {employee.Gender}");
        Console.WriteLine($"Employee EmpID : {employee.EmpID}");
        Console.WriteLine($"Employee Role : {employee.Role}");
    }
}