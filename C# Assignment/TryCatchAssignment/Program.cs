using System;
namespace TryCatchAssignment;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the First Number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Division : {firstNumber / secondNumber}");
        }
        catch(ArithmeticException ex)
        {
             Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}