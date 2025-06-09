namespace DotNetCourse.src.SessionTwo.AppControl;

using System;

public static class Iteration {
    public static void Run() {
        int number;
        int counter = 1;
        string userInput;
        bool isValidInput;

        while (counter <= 5) {
            Console.WriteLine($"Counter - {counter}");
            counter++;
        }

        Console.WriteLine("\nEnter your name: ");
        while ((userInput = Console.ReadLine() ?? "") != "exit") {
            Console.WriteLine($"\nYou entered: {userInput}");
        }

        do {
            Console.Write("\nPlease enter a valid integer: ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
            if (!isValidInput) {
                Console.WriteLine("Please try again");
            }
        } while (!isValidInput);

        Console.WriteLine($"You entered a valid number: {number}");

        for (int i = 0; i<=5; i++) {
            for ( int j = 0; j < i; j++) {
                Console.Write("*\t");
            }
            Console.WriteLine();
        }
    }
}