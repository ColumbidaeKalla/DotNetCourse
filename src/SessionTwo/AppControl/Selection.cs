namespace DotNetCourse.src.SessionTwo.AppControl;

using System;

public static class Selection {
    public static void Run() {
        uint number = 20;
        bool isActive = true;
        bool isLoggedIn = true;
        int i = 25, j = 20, k = 30;

        if (isLoggedIn && isActive) {
            if (i > j && i > k) Console.WriteLine("i is greatest");

            if (j > k && j > i) {
                Console.WriteLine("j is greatest");
            } else {
                Console.WriteLine("k is greatest");
            Console.WriteLine("Invalid User");
            }

            if (i == j) {
                Console.WriteLine("i == j");
            } else if (i > j) {
                Console.WriteLine("i > j");
            } else if (i<j) {
                Console.WriteLine("i<j");
            } else {
                Console.WriteLine("Invalid Number");
            }

            switch (number) {
                case 1:
                    Console.WriteLine("Number is one");
                    break;
                case 2:
                    Console.WriteLine("Number is two");
                    break;
                case 3:
                    Console.WriteLine("Number is three");
                    break;
                default:
                    Console.WriteLine("Unknown number");
                    break;
            }
        }
    }
}