namespace DotNetCourse.src.SessionThree.AppInterface;

using System;

public interface IShapeArea {
    //Only method signature abstract by default
    public double GetArea();
}

public interface IShapeDraw {
    public void GetPosition();
}

//Multiple interface - dynamic polymorphism with abstract
public abstract class CommonShape : IShapeArea, IShapeDraw {
    private readonly int id;

    protected CommonShape(int id) {
        this.id = id;
    }

    public abstract string Name { get; set; }

    public virtual void LocaateUser() {
        Console.WriteLine("This is inside LocateUser");
    }

    //These two come from the interface above
    public abstract double GetArea();
    public abstract void GetPosition();

    public int GetId() {
        return id;
    }
}

//Hybrid
public class Circle : CommonShape {
    private double radius = 0;
    private string name = "Circle";

    public Circle(int id) : base(id) {
        
    }
    public override string Name {
        get { return name; }
        set { name = value; }
    }

    public double Radius {
        get { return radius; }
        set { radius = value; }
    }

    public override void LocaateUser() {
        Console.WriteLine("This is inside overridden LocateUser method");
    }

    public override double GetArea() {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2);
    }

    public override void GetPosition()
    {
        Console.WriteLine($"Drawing a {Name}");
    }
}

public static class ShapeManager {
    public static void PrintShapeInfo(CommonShape shape) {
        shape.GetPosition();
        Console.WriteLine($"Shape name: {shape.Name}");
        Console.WriteLine($"Area: {shape.GetArea()}");
    }
}