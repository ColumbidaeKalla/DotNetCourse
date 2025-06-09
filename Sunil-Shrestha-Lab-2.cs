// namespace DotNetCourse;

// using System;

// public static class SunilShresthaLab2 {
//     private static void Main(string[] args) {
//         Console.Write("Enter first number: ");
//         float num1 = Convert.ToSingle(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         float num2 = Convert.ToSingle(Console.ReadLine());

//         Console.WriteLine("\nSelect an operation:");
//         Console.WriteLine("1. Add");
//         Console.WriteLine("2. Subtract");
//         Console.WriteLine("3. Multiply");
//         Console.WriteLine("4. Divide");

//         Console.Write("\nEnter your choice (1/2/3/4): ");
//         int choice = Convert.ToInt32(Console.ReadLine());
        

//         float result = 0;
//         switch (choice) {
//             case 1:
//                 result = num1 + num2;
//                 Console.WriteLine($"\n{num1} + {num2} = {result}");
//                 break;

//             case 2:
//                 result = num1 - num2;
//                 Console.WriteLine($"\n{num1} - {num2} = {result}");
//                 break;

//             case 3:
//                 result = num1 * num2;
//                 Console.WriteLine($"\n{num1} * {num2} = {result}");
//                 break;

//             case 4:
//                 if (num2 != 0) {
//                     result = num1 / num2;
//                     Console.WriteLine($"\n{num1} / {num2} = {result}");
//                 } else {
//                     Console.WriteLine("\nError: Cannot divide by zero.");
//                 }
//                 break;

//             default:
//                 Console.WriteLine("\nInvalid choice. Please select a valid operation.");
//                 break;
//         }
//     }
// }