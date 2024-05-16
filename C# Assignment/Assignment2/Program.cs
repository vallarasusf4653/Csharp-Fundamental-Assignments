using System;
namespace Assignment2;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First NUmber : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second NUmber : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the Third NUmber : ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine($"{firstNumber} is largest number");
        }
        else if (secondNumber >= thirdNumber)
        {
            Console.WriteLine($"{secondNumber} is largest number");
        }
        else
        {
            Console.WriteLine($"{thirdNumber} is largest number");
        }

    }
}