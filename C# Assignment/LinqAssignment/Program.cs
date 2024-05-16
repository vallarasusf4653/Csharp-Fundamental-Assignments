using System;
namespace LinqAssignment;
public class Program
{
    public static void Main(string[] args)
    {
        Question1();
        Question2();

    }

    static void Question1()
    {
        string[] cities = new string[] { "ABU DHABI", "AMSTERDAM", "ROME", "MADURAI", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI" };
        Console.Write("Input starting character for the string : ");
        char firstCharacter = char.Parse(Console.ReadLine().ToUpper());
        Console.Write("Input ending character for the string : ");
        char endCharacter = char.Parse(Console.ReadLine().ToUpper());
        var city = cities.Where(city => city.StartsWith(firstCharacter) && city.EndsWith(endCharacter));
        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
    }

     static void Question2()
    {
        Console.WriteLine();
        Console.WriteLine("Question 2");
        string[] cities = new string[] { "ABU DHABI", "AMSTERDAM", "ROME", "PARIS","CALIFORNIA","LONDON", "NEW DELHI", "ZURICH", "NAIROBI" };
        var city = cities.OrderBy(city=>city.Length);
        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
    }

}