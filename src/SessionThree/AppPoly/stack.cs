namespace DotNetCourse.src.SessionThree.AppPoly;
using System;

public class CustomStack<T>
{
    private int top;
    private T[] elements;

    public string stackMessege = "This is parent stack";

    public CustomStack(int capacity)
    {
        elements = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == elements.Length - 1) throw new Exception("Stack overflow");
        elements[++top] = item;
    }

    public T Pop()
    {
        if (top == -1) throw new Exception("Stack underflow");
        return elements[top--];
    }

    public void ShowStack()
    {
        for (int i = 0; i <= top; i++)
        {
            T item = elements[i];
            Console.WriteLine(item);
        }
    }
}

public class AnotherStack : CustomStack<int>
{
    public new string stackMessege = "This is another stack";

    //calling parent constructor
    public AnotherStack(int capacity) : base(capacity) { }

    public void ShowBase()
    {
        //Using the base keyword
        Console.WriteLine(base.stackMessege);
        Console.WriteLine(this.stackMessege);
    }
}