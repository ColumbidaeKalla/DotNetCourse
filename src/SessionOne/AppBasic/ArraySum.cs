namespace DotNetCourse.src.SessionOne.AppBasic;
using src.Constant;
using System;

public static class ArraySum 
{
    public static void Run()
    {
        int totalno ,sum = 0;
        int[] numbersToadd = new int[5];

        Console.WriteLine("Enter the number of elements (5 max)");
        string totalNoInput = Console.ReadLine() ?? string.Empty ;


        if(!int.TryParse(totalNoInput, out totalno))
        {
            Console.WriteLine("\n😎Invalid input man");
            return;
        }

        Console.WriteLine("\nEnter a numerivval elements");
        for(int i = 0;i<totalno;i++)
        {
            bool isConversionSuccessful = int.TryParse(Console.ReadLine(),out int convertednUmber) ;

            if(isConversionSuccessful)
            {
                numbersToadd[i] = convertednUmber;
            }
            else
            {
                numbersToadd[i]=0;
            }
        }

        for(int i = 0;i<totalno;i++)
        {
            sum += numbersToadd[i];
        } 

        Console.WriteLine($"\nThe final sum is {sum}");
    }
}