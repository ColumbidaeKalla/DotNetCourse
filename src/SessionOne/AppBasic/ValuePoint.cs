namespace DotNetCourse.src.SessionOne.AppBasic;

using System;

public class ValuePoint {
    public int X {get; set;}
    public int Y {get; set;}
}

public class CopyByValue {
    public static void Run() {
        ValuePoint pointOne = new ValuePoint();
        pointOne.X = 10;

        ValuePoint pointTwo = pointOne;

        Console.WriteLine("Before changing value of x in pointOne");
        Console.WriteLine($"Point One X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");

        pointOne.X = 20;

        Console.WriteLine("\nAfter changing value of x in pointOne");
        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");
    }
}