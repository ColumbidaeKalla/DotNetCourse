namespace DotNetCourse.src.SessionOne.AppBasic;

using System;

public static class Character {
    public static void Run() {
        int numOne = 10;
        char copyright = '\u00A9';
        char trademark = '\u2122';
        string lastName = "Shrestha";
        string firstName = "Sunil";
        string directoryPath = @"src\SessionOne\AppBsic\Character.cs";

        string fullName = firstName + " " + lastName + " " + numOne;
        bool resultName = firstName == lastName;

        Console.WriteLine("Result of comparison " + firstName.CompareTo(lastName));

        if (firstName.CompareTo(lastName) == 0) {
            Console.WriteLine("First name is equal to last name");
        }

        Console.WriteLine($"Full name {copyright} is {fullName} {trademark}");
        Console.WriteLine($"Current directory is " + directoryPath);
        Console.WriteLine($"Comparison result is {resultName}");
    }
}