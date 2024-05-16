using System;
namespace Sample;
public class Sample
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hierarchical Inheritance");
        Dog obj = new Dog();
        obj.Bark();
        obj.Eat();

        Cat obj1 = new Cat();
        obj1.Meow();
        obj1.Eat();

        Console.WriteLine("Mutli level Inheritance");
        Pet obj3 = new Pet();
        obj3.Eat();
        obj3.Meow();
        obj3.PetName();
    }
}

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
public class Dog:Animal{
    public void Bark()
    {
         Console.WriteLine("Dog is eating");
    }
}

public class Cat:Animal{
    public void Meow()
    {
         Console.WriteLine("Cat is eating");
    }
}
public class Pet:Cat{
    public void PetName()
    {
         Console.WriteLine("Jack is Pet Name");
    }
}