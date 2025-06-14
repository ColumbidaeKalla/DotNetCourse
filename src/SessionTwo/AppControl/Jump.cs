namespace DotNetCourse.src.SessionTwo.AppControl {
    using System;

    public class Foo { }

    public static class Jump {
        public static void Run() {
            int count = 1, number = 1;
            int[] numbers = new int[] { 2, 4, 6, 12, 8, 10 };

            for (int i = 0; i< numbers.Length; i++) {
                if (numbers[i] > 10) {
                    Console.WriteLine($"Number greater than 10 found: {numbers[i]}");
                    break;
                }

                Console.WriteLine($"Number {numbers[i]} at index {i}");
            }

            Console.WriteLine();
            Console.Write("Odd numbers: ");
            while (count <= 10) {
                if (count % 2 == 0) {
                    count++;
                    continue;
                }
                
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
            ProcessNumbers();
            Console.WriteLine();

            Console.WriteLine("\nFrom goto statement");
            startLoop:
            if (number <= 5) {
                Console.Write(number + " ");
                number++;
                goto startLoop;
            }
        }

        private static void ProcessNumbers() {
            Console.Write("Numbers from function: ");
            for (int i = 1; i <= 10; i++) {
                if (i == 5) {
                    break;
                }
                Console.Write(i + " ");
            }
            Console.Write("\nThe breaking condition has been encountered");
        }
    }
    namespace Inner {
        public class Foo { }
        public class Test {
            // Foo? innerFoo;
            // AppControl.Foo? outerFoo;
        }
    }
}