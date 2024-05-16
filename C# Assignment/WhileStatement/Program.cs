using System;
namespace WhileStatement;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Which city is capital of India?");
        Console.Write("1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata\n");
        bool result = true;
        while (result)
        {
            Console.Write("Enter your Choice : ");
            int value = int.Parse(Console.ReadLine());
            if (value == 2)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("Press Y to continue,Press N to close");
            char input = char.Parse(Console.ReadLine().ToUpper());
            if (input == 'Y')
            {
                result = true;
            }
            else if(input=='N')
            {
                result = false;
            }
        }


    }
}