/* namespace DotNetCourse;

using System;

public class Person {
    public string Name;
    public int Age;
    public static string Country;

    // Static Constructor
    static Person() {
        Country = "Nepal";
        Console.WriteLine("Static constructor: Country set to Nepal.");
    }

    // Default Constructor
    public Person() {
        Name = "Unknown";
        Age = 0;
        Console.WriteLine("Default constructor");
    }

    // Parameterized Constructor
    public Person(string name, int age) {
        Name = name;
        Age = age;
        Console.WriteLine("\nParameterized constructor");
    }

    // Method to Display Information
    public void Display() {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Country: {Country}");
    }
}

public static class SunilShresthaLab4 {
    public static void Main() {
        // Creating object with Default Constructor
        Person person1 = new Person();
        person1.Display();

        // Creating object with Parameterized Constructor
        Person person2 = new Person("Sunil Shrestha", 21);
        person2.Display();
    }
}
 */