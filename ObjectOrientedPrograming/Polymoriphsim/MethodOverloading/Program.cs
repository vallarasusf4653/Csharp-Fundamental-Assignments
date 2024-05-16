using System;
namespace MethodOverloading;
public class Program 
{
    public static void Main(string[] args)
    {
        Sample obj = new Sample();
        obj.Sum();
        obj.Sum(5,5);
        
    }
}