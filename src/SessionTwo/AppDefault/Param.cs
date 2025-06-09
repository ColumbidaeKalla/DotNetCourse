namespace DotNetCourse.src.SessionTwo.AppDefault;

using System;

public static class Param {
    public static void Run() {
        int mainNumber = 10;

        AddNumber(numOne: 1);

        IncreamentByOne(ref mainNumber);
        Console.WriteLine($"Old number is {mainNumber}");

        JumbleNumbers(a: 5, b: 6, out int numOne, out int numTwo);

        Console.WriteLine($"Sum of params = {MajorSum(1, 1, 1, 1)}\n");

        Console.Write("Enter the limit for multiplication: ");
        int limit = int.Parse(Console.ReadLine() ?? "0");

        MajorMultiplication(limit, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
    }

    private static void AddNumber(int numOne, int numTwo = 10) {
        int result = numOne + numTwo;
        Console.WriteLine("Sum = " +result);
    }

    private static void IncreamentByOne(ref int num) {
        num += 1;
        Console.WriteLine($"New number is {num}");
    }

    private static bool JumbleNumbers(int a, int b, out int x, out int y) {
        x = b;
        y = a;
        return true;
    }

    private static int MajorSum(params int[] numbers) {
        int Sum = 0;
        foreach (int num in numbers) Sum += num;
        return Sum;
    }

    private static void MajorMultiplication(int limit, params int[] numbers) {
        int[,] result = new int[numbers.Length, limit];

        for (int i = 0; i < numbers.Length; i++) {
            for (int j = 0; j<10; j++) {
                result[i, j] = numbers[i] * (j + 1);
            }
        }

        for (int i = 0; i < result.GetLength(0); i++) {
            Console.Write($"Multiplication of {numbers[i]}: ");
            for (int j = 0; j < result.GetLength(1); j++) {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}