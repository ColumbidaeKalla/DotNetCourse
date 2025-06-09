using System;
using System.Collections.Generic;

namespace DotNetCourse.src.SessionThree.AppPoly;

public class Queue
{
    public static void RunQueue()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Front element: {queue.Peek()}");

        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");

        Console.WriteLine($"Number of elements in queue: {queue.Count}");

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
    public static void RunStack()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Top element: {stack.Peek()}");

        Console.WriteLine($"Popped: {stack.Pop()}");
        Console.WriteLine($"Popped: {stack.Pop()}");

        Console.WriteLine($"Number of elements in stack: {stack.Count}");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
        stack.Clear();

        Console.WriteLine($"Number of elements after clearing: {stack.Count}");
    }
   
}