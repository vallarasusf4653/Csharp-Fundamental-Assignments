using System;
namespace InterfaceSample;
public class Program : iWallet
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Addition {a + b}");
    }
    public string Name { get; set; }


    public static void Main(string[] args)
    {
        Program obj = new Program();
        obj.Add(5, 4);
        obj.Name = "syncfusion";
        Console.WriteLine(obj.Name);

    }
}