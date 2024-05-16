using System;
namespace ForIteration;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the 10 numbers : ");
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            int value = int.Parse(Console.ReadLine());
            sum +=value;
        }
        Console.WriteLine($"The sum of 10 number is : {sum}");
        Console.WriteLine($"The average of 10 number  is : {(double)sum / 10}");

    }
}