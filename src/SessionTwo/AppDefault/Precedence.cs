namespace DotNetCourse.src.SessionTwo.AppDefault;

using System;
using System.Text;

public static class Precedence {
    public static void Run() {
        Console.WriteLine(1 + 2 * 3);
        Console.WriteLine(8 / 4 / 2);

        {
            string address;
            int x = 0, y = 0;

            x += 1;
            address = "USA";
            Console.WriteLine(address);
            y++;
            y = Math.Max(x, 5);
            new StringBuilder();
        }
    }
}