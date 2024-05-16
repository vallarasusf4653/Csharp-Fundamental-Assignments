using System;
namespace AbstractSample;
public  class Program :B
{
    public override string Name { get; set;}

    public static void Main(string[] args) 
    {
       Program obj = new Program();
       obj.Add();
       obj.Message();
       obj.Name="vallarasu";
       Console.WriteLine(obj.Name);
       obj.Age=22;
       Console.WriteLine(obj.Age);
       
       
    }
}