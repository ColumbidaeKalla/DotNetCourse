namespace DotNetCourse.src.SessionTwo.AppDefault;

using System;

public static class Definite {
    private static int age = 0;
    private static bool isOn = false;
    private static string? name = "John Doe";

    public static void Run() {
        int point = 10;

        int[] numbers = new int[5];
        string[] sports = new string[2];

        Console.WriteLine($"Is on? = {isOn}");
        Console.WriteLine($"Point is {point}");
        Console.WriteLine($"Name = {name ?? "Empty"}\tAge = {age}");
        Console.WriteLine($"This first value of sports = {sports[0]}");
        Console.WriteLine($"This first value of sports = {numbers[0]}");

        AddTwoNumbers(1);
    }

    private static void AddTwoNumbers(int a, int b = 1) {
        Console.WriteLine("Sum is " + a + b);
    }
}