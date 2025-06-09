namespace DotNetCourse.src.SessionFour.AppException;

using System;

public class AppTryCatch
{
    private static int numOne = 10, numTwo = 2;
    private static string[] nameList = ["Sunil", "Sanjeev", "Subash"];
    public static void ZeroDivision()
    {
        try
        {
            int result = numOne / numTwo;

            if (result < 10) throw new ArithmeticException("Result is negative");

            Console.WriteLine($"Division Result: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Cannot divide by zero at {e.TargetSite}");
        } 
        catch (ArithmeticException e)
        {
            Console.WriteLine($"Arithmetic error at {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error occurred: {e}");
        }
        finally
        {
            Console.WriteLine("This always runs");
        }

        Console.WriteLine("This is outside the try-catch block");
    }

    public static void CheckRange()
    {
        try
        {
            nameList[3] = "Sunil"; // This will throw an IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Index out of range at {e.Message}");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Invalid operation at {e}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format error at {e}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error occurred: {e}");
        }

        // This is Finally, This block will always execute, regardless of whether an exception was thrown
        Console.WriteLine("This always runs after the index check");
    }
}