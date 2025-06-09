namespace DotNetCourse.src.SessionThree.AppPoly;

using System;
using DotNetCourse.src.Constant;
using DotNetCourse.src.SessionThree.AppInterface;
public class RunAppPoly
{
    public static void RunPolymorphism()
    {
        //Upcasting - child to parent
        User admin = new AdminUser();
        User guest = new GuestUser();

        //Downcasting - parent to child
        AdminUser adminUser = (AdminUser)admin;

        adminUser.Great();

        GuestUser? guestUser = guest as GuestUser;
        guestUser?.Great();

    }
    public static void RunOperatorOverloading()
    {
        ComplexNumber c1 = new(2, 3);
        ComplexNumber c2 = new(4, 5);

        ComplexNumber result = c1 + c2;
        Console.WriteLine(result.ToString());

        Increment inc = new(5);
        Increment resultOne = ++inc;
        Console.WriteLine($"This is incremented value: {resultOne.ToString()}");
    }
    public static void RunSwapNumbers()
    {
        int a = 5, b = 10;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        SwapNumbers.SwapValues<int>(ref a, ref b);
        Console.WriteLine($"After Swap: a = {a}, b = {b}");

        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"Before swap: str1 = {str1}, str2 = {str2}");
        SwapNumbers.SwapValues<string>(ref str1, ref str2);
        Console.WriteLine($"After swap: str1 = {str1}, str2 = {str2}");
    }

    public static void RunCustomStack()
    {
        int x = 9;
        object y = x;
        int z = (int)y;

        CustomStack<int> myStack = new(4);
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Pop();
        myStack.ShowStack();

        //Getting the type of an object
        Console.WriteLine(myStack.GetType());
        Type stackType = typeof(CustomStack<string>);
        Console.WriteLine($"Type of CustomStack: {stackType}");

        Console.WriteLine($"User Role: {AppEnum.UserRole.admin} at position {(int)AppEnum.UserRole.admin}");

        AnotherStack newStack = new(10);
        newStack.ShowBase();
    }
}