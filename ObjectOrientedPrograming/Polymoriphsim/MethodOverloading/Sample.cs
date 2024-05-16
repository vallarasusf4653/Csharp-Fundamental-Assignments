using System;

namespace MethodOverloading
{
    public class Sample
    {
        public void Sum()
        {
            Console.WriteLine("Welcome");
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine($"SUM : {a + b}");
        }
    }
}
