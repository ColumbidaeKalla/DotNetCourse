namespace DotNetCourse.src.SessionOne.AppOperator;

using System;

public class Address {
    public string? Street { get; set; }

    public void ShowInfo() {
        System.Console.WriteLine($"This is inside Address");
    }
}

public class User {
    private const int _age = 20;
    private const bool _isMarried = true;

    public string? Name { get; set; }
    public Address? Address { get; set; }

    public void ShowInfo() {
        System.Console.WriteLine($"Name: {Name}\nAge: {_age}\nIsMarried: {_isMarried}");
    }
}

public static class ElvisPresley {
    public static void Run() {
        User user = new User();
        user.Name = "Sunil Shrestha";


        Address address = new Address();
        address.Street = "Bhaktapur";
        

        string userName = user.Name;
        string separateStreet = address.Street;
        // string userStreet = user?.Address?.Street ?? "Deafult Street";
        string userStreet = "Bhaktapur";

        Console.WriteLine($"User name is {userName}");
        Console.WriteLine($"Separate street is {separateStreet}");

        if (userStreet is not null) {
            Console.WriteLine($"User street is {userName} ");
        } else Console.WriteLine("User has no street");
    }
}