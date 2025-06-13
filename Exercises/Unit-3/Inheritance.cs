namespace DotNetCourse.Exercises.Unit3;

using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Dog Eats");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Poppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Poppy weeps");
    }
}

class Inhertance
{
    public static void Main()
    {
        Dog dog = new Dog();
        Poppy poppy = new Poppy();

        dog.Bark(); //single Inheritance
        poppy.Eat(); //Multi-Level Inheritance
        poppy.Weep(); //Multi-Level Inheritance
    }
}