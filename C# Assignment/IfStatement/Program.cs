using System;
namespace IfStatement;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Input : ");
        string userInput = Console.ReadLine().ToUpper();
        if (userInput.Equals("A"))
        {
            Console.WriteLine("Grade A denotes 9 Points");
        }
        else if (userInput.Equals("B"))
        {
            Console.WriteLine("Grade B denotes 8 Points");
        }
        else if (userInput.Equals("C"))
        {
            Console.WriteLine("Grade C denotes 7 Points");
        }
        else if (userInput.Equals("D"))
        {
            Console.WriteLine("Grade D denotes 6 Points");
        }
        else
        {
            Console.WriteLine("This is not valid Grade");
        }
    }
}