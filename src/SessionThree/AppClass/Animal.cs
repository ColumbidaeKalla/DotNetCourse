namespace DotNetCourse.src.SessionThree.AppClass;
using System;

public class Animal {
    private uint? _age;
    private readonly string? _name;
    private readonly string? _species;

    public string? Name{get;set;}
    public string? Species{get;set;}


    public uint? Age {

        get => _age;
        set {
            if (value < 6) throw new ArithmeticException("Invalid age");
            _age = value;
        }
    }

    static Animal() {
        Console.WriteLine("Inside Animal Constructor");
    }

    public Animal(string name, uint age, string species) {
        _age = age;
        _name = name;
        _species = species;
        
    }

    /* public Animal() {
        Console.WriteLine("Animal Constructor without paramtere");
    } */

    public void MakeSound() {
        Console.WriteLine($"{_name} is making a sound");
    }

    public void MakeSound(string animalName) {
        Console.WriteLine($"{animalName} is method overloading!");
    }

    public void AnimalDerails() {
        Console.WriteLine("Animal Details: ");
        Console.WriteLine($"Name >> {_name}\nSpecies >> {_species}\nAge >> {_age}");
    }

    Animal() {
        Console.WriteLine("Animal class destroyed");
    }

}