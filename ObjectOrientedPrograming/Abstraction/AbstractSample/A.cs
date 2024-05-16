using System;

namespace AbstractSample
{
    public abstract class A
    {
        public A()
        {
            Console.WriteLine("Hello");
        }

        abstract public void Add();
        public void Message()
        {
            Console.WriteLine("Hi all,");
        }

        public abstract string Name { get; set; }
        public int Age { get; set; }
    }
}
