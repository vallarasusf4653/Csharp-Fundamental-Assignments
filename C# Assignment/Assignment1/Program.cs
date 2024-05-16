using System;
namespace Assignment1;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First Number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"Addition : {firstNumber + secondNumber} ");
        Console.WriteLine($"Subtraction : {firstNumber - secondNumber} ");
        Console.WriteLine($"Multiplication : {firstNumber * secondNumber} ");
        Console.WriteLine($"Division : {((double)firstNumber / (double)secondNumber).ToString("0.00")} ");
        Console.WriteLine($"Modulus : {firstNumber % secondNumber} ");



    }
}