namespace DotNetCourse.src.SessionFour.AppDelegate;

using System;


public class RunAppDelegate
{
    private static readonly MathDelegate AddNumbers = (a, b) =>
    {
        Console.WriteLine($"Sum from anonymous function is {a + b}");
        return a + b;
    };


    public static void RunSimpleDelegate()
    {
        MathDelegate addNum = new(MathOperations.Add);

        int addResult = addNum(5, 10);
        Console.WriteLine($"Addition result = {addResult}");


        MathDelegate multicast = new(MathOperations.Add);
        multicast += MathOperations.Subtract;
        multicast += MathOperations.Multiply;

        int multicastResult = multicast(2, 2);
        Console.WriteLine($"Multicast result = {multicastResult}");
        RunFuncDelegate(AddNumbers);
    }

    public static void RunFuncDelegate(MathDelegate addCallBack)
    {
        Func<int, int, int> addDelegate = MathOperations.Add;
        int addResult = addDelegate(5, 10);
        Console.WriteLine($"Addition result = {addResult}");


        //Action delegate can only be used with void return type
        Action<string> greet = BasicOperations.GreetUser;
        greet("Sunil");

        addCallBack(10, 10);
    }
}