namespace DotNetCourse.src.SessionThree.AppClass;

using System;

public struct Point {
    private int _x;
    private int _y;

    public Point(int x, int y) {
        _x = x;
        _y = y;
    }

    public int X {
        get => _x;
        set {
            if (value < 18) throw new ArithmeticException("Invalid value");
            _x = value;
        }
    }

    public int Y {
        get => _y;
        set => _y = value;
    }
}