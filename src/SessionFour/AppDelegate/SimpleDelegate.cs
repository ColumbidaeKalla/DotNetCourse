namespace DotNetCourse.src.SessionFour.AppDelegate;

using System;


//[modifier ] delegate [retur_type] [delegate_name] ([paramter_list])
public delegate int MathDelegate(int x, int y);

public static class MathOperations
{

    //expression lambda
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
}


public static class BasicOperations
{
    public static void GreetUser(string name) => Console.WriteLine($"Hello {name}");
}