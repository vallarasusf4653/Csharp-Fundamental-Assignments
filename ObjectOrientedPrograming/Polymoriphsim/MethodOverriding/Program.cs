using System;
namespace MethodOverriding
{


public class Program 
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.Run();
    }
}

public class A 
{
    public void Run()
    {
        Console.WriteLine("Welcome all");
    }
}

public class B : A 
{
    public void Run()
    {
       // base.Run();       used to print parent class Run() method
        Console.WriteLine("Hello all");
    }
}
}