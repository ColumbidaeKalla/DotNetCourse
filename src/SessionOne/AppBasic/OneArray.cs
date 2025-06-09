namespace DotNetCourse.src.SessionOne.AppBasic;
using System;

public static class OneArray 
{
    public static void Run()
    {
        int[] numbers = new int[5];
        char[] letters = { 'a', 'e', 'i', 'o', 'u' };

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        int sum = 0; 

        Console.WriteLine("Elements in numbers are");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
            sum += numbers[i]; // Adding numbers to sum
        }

        Console.WriteLine("Sum of numbers: " + sum); // Printing the sum

        Console.WriteLine("\nElements in letters are");
        foreach (char letter in letters)
        {
            Console.WriteLine(letter + " ");
        }
    }
}
