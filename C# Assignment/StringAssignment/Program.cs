using System;
using System.Linq;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string userInput = "syncfussion";

        Question1(userInput);
        Question2(userInput);
        Question34(userInput);
        Question5();
        Question6();
    }

    static void Question1(string value)
    {
        for (int i = 0; i < value.Length; i += 2)
        {
            Console.Write(value[i]);
        }
    }



    static void Question2(string value)
    {
        Console.WriteLine();
        //Console.WriteLine(value.Replace('n', 'N'));
        string str = string.Empty;
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == 'n')
            {
                str += 'N';
            }
            else
            {
                str += value[i];
            }
        }
        Console.WriteLine(str);
    }



    static void Question34(string value)
    {
        for (int i = value.Length - 1; i >= 0; i--)
        {
            Console.Write(value[i]);
        }
        Console.WriteLine();
        Console.WriteLine($"Length of the String : {value.Length}");
    }



    static void Question5()
    {
        Console.Write("Enter the First String :");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second String :");
        string str2 = Console.ReadLine();
        string str3 = string.Empty;

        for (int i = 0; i < str1.Length; i++)
        {
            if (i <= 3)
            {
                str3 += str1[i];
            }
        }
        int length = str2.Length - 3;
        for (int i = 0; i < str2.Length; i++)
        {
            if (i >= length)
            {
                str3 += str2[i];
            }
        }
        Console.Write(str3);

    }


    static void Question6()
    {
        Console.WriteLine();
        string cities = "Chennai,Trichy,Mumbai";
        string[] stringArray = cities.Split(',');
        int count = 1;
        foreach (string value in stringArray)
        {
            Console.WriteLine($"{count}.{value}");
            count++;
        }
    }
}