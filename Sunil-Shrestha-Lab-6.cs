/* namespace DotNetCourse;

using System;

class Calculator {
    // Method Overloading: same method name, different parameters
    public int Add(int a, int b) {
        return a + b;
    }

    public int Add(int a, int b, int c) {
        return a + b + c;
    }
}

class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal {
    // Method Overriding: overriding base class method
    public override void Speak() {
        Console.WriteLine("Dog barks");
    }
}

class Program {
    static void Main() {
        // Overloading
        Calculator calc = new Calculator();
        Console.WriteLine("Add 2 numbers: " + calc.Add(2, 3));
        Console.WriteLine("Add 3 numbers: " + calc.Add(2, 3, 4));

        // Overriding
        Animal myDog = new Dog();
        myDog.Speak();
    }
}
 */