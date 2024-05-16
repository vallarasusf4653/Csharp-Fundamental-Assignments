using System;
namespace DateTmeAssignment;
public class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        Console.WriteLine($"Month of Day : {date.Month}");
        Console.WriteLine($"Month of Day : {date.ToString("MMM")}");
        Console.WriteLine($"Previous Date : {date.AddDays(-3).ToString("dd/MM/yyyy hh:mm:ss tt")}");
        Console.WriteLine($"Time : {date.ToString("hh:mm:ss tt")}");
    }
}