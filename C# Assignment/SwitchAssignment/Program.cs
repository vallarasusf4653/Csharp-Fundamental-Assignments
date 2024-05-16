using System;
namespace SwitchAssignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First Number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the Seccond Number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Menu : \n\tPress 1 to add two number\n\tPress 2 to subtract two number\n\tPress 3 to multiply two number\n\tPress 4 to divide two number\n");
        Console.Write("Please Mention Your Option : ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                {
                    Console.WriteLine($"Addition : {firstNumber + secondNumber}");
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"Subtraction : {firstNumber - secondNumber}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine($"Multiplication : {firstNumber * secondNumber}");
                    break;
                }
            case 4:
                {
                    Console.WriteLine($"Division : {((double)firstNumber /(double) secondNumber).ToString("0.00")}");
                    break;
                }
        }

    }
}