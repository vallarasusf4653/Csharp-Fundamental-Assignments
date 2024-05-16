using System;
namespace MultipleInheritance;
public class Program
{
    public static void Main(string[] args)
    {
        Sample3 obj = new Sample3();
        obj.Add();
        obj.Sub();
    }
}

interface Sample1
{
    void Add();
}
interface Sample2
{
    void Sub();
}
public class Sample3 : Sample1, Sample2
{
    public void Add()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"Addition : {a + b}");
    }
    public void Sub()
    {
        int a = 30;
        int b = 20;
        Console.WriteLine($"Subtraction : {a - b}");
    }
}