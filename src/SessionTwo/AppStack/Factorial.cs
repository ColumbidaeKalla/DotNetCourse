namespace DotNetCourse.src.SessionTwo.AppStack;

using System;

using System.Text;
using DotNetCourse.src.SessionOne.AppOperator;

public class Factorial {
    public static void Run() {
        int factorialNumber = 4;
        int result = GetFactorial(factorialNumber);

        Console.WriteLine($"\nFactorial of {factorialNumber} = {result}\n");

        BuildString();
    }

    private static int GetFactorial(int number) {
        if (number == 0) return 1;
        return number * GetFactorial(number - 1);
    }

    private static void BuildString() {
        StringBuilder name = new StringBuilder("Sunil");
        Console.WriteLine(name);
        
        StringBuilder address = new StringBuilder("Bhaktapur");
        StringBuilder street = address;

        Console.WriteLine(street);
    }

}