namespace DotNetCourse.src.SessionOne.AppBasic;
using System;

public static class JaggedArray {
    public static void Run() {
        int[][] numbers = new int[3][]{
            [1,2,3],
            [2,3],
            [4,5]
        };

        char [][] letters = new char[3][] {
            ['a','e','i'],
            ['o','u'],
            ['d','f'],
        };

        Console.WriteLine("Elements in numbers list are");
        foreach (int[] rows in numbers) {
            foreach (int items in rows) {
                int sum = 0;
                foreach (int item in rows) {
                    Console.Write(item + " ");
                    sum += item;
                }
                Console.WriteLine($" -> Sum: {sum}");
            }
        }
    }
}