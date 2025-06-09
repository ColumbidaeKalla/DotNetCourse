namespace DotNetCourse.src.SessionThree.AppPoly;

using System;

//swap two numbers using a generic method
public static class SwapNumbers
{
    //A generic method that works with type T
    public static void SwapValues<T>(ref T a, ref T b)
    {
        T temp = a;

        //swapping values
        a = b;
        b = temp;
    }

}