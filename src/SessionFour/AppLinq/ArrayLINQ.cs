namespace DotNetCourse.src.SessionFour.AppLinq;

using System;
using System.Linq;

public static class Link
{
    private static int[] numberList = { 1, 2, 3, 4, 5, };
    private static string[] names = { "Sunil", "Ram", "Sita", "Roman", "Suroj", };

    public static void CheckEven()
    {
        var evenNumbers = from num in numberList
                          where num % 2 == 0
                          orderby num descending
                          select num;

        foreach (int num in evenNumbers) Console.WriteLine($"{num}");
        Console.WriteLine();
    }

    public static void CheckOdd()
    {
        var oddNumbers = from num in numberList
                         where num % 2 != 0
                         orderby num descending
                         select num;

        foreach (int num in oddNumbers)
            Console.WriteLine($"Oddnumbers are: {num}");

        Console.WriteLine();
    }


    public static void GroupNames()
    {
        var GroupNames = from name in names
                         group name by name[0] into nameGroup
                         orderby nameGroup.Key ascending
                         select nameGroup;
        foreach (var group in GroupNames)
        {
            Console.WriteLine($"Names starting with '{group.Key}':");
            foreach (string name in group) Console.WriteLine($" >> {name}");
        }
    }
}