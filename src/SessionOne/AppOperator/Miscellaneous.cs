namespace DotNetCourse.src.SessionOne.AppOperator;

using System;

public static class Miscellaneous {
    public static unsafe void Run() {
        int year = 2025;
        int intSize = sizeof(int);
        int charSize = sizeof(char);
        int floatSize = sizeof(float);
        int doubleSize = sizeof(double);

        int* yearPtr = &year;

        System.Console.WriteLine(
            $"sizeof(int) = {intSize}\n" +
            $"sizeof(char) = {charSize}\n" +
            $"sizeof(float) = {floatSize}\n" +
            $"sizeof(double) = {doubleSize}\n"
        );

        Console.WriteLine($"type of int = {typeof(int)}");
        Console.WriteLine($"type of char = {typeof(char)}");

        Console.WriteLine($"'year' address is memory = " + (int)yearPtr);
        Console.WriteLine($"'year' value in memory = " + *yearPtr);

        User john = new User();

        if (john is User) {
            Console.WriteLine($"\ntype of john is {typeof(User)}");
            john.ShowInfo();
        }

        object? planet = null;
        string mercury = planet as string ?? "Earth";

        Console.WriteLine($"\nmercury = {mercury} \t type of mercury = {mercury.GetType()}");

        int maxResult = CheckMax(a: 20, b: 20, c: 50);

        Console.WriteLine($"\nMax is {maxResult}");

    }

    private static int CheckMax(int a, int b, int c){
        return (a > b && a > c) ? a : (b > a && b > c) ? b : c;
    }
}