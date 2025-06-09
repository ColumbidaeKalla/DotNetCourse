using DotNetCourse.src.SessionThree.AppClass;

using System;
using System.Security.Cryptography.X509Certificates;

public class Optimus {
    public int publicFeild = 10;

    public void PublicMethod() {
        Console.WriteLine("Public method");
    }

    // private readonly int privateFeild = 15;

    private void PrivateMethod() {
        Console.WriteLine("Private method");
    }

    internal int internalFeild = 20;

    internal void InternalMethod() {
        Console.WriteLine("Internal Method");
    }

    protected int protectedFeild = 30;

    protected void ProtectedMethod() {
        Console.WriteLine("Protected method");
    }

    private protected class Helper {
        public void Info() {
            Console.WriteLine("This is an internal method");
        }
    }

    public void Check() {
        Helper helper = new();
        helper.Info();
    }
}

//Derived class extending
public class Derived : Optimus {
    public void CheckInfo() {
        Helper _ = new();
        Console.WriteLine($"PublicFeild: {publicFeild}");
        Console.WriteLine($"Internalfeild: {internalFeild}");
        Console.WriteLine($"Protectedfeild: {protectedFeild}");
        // Console.WriteLine($"ProtectedFeild: {privateFeild}");
        PublicMethod();
        InternalMethod();
        ProtectedMethod();
        // PrivateMethod();
    }
}

public class Megatron {
    //seperate class can access public and internal members
    public void checkIsAuthenticated() {
        Optimus prime = new();

        Console.WriteLine($"PublicFeild: {prime.publicFeild}");
        Console.WriteLine($"InternalFeild: {prime.internalFeild}");
        // Console.WriteLine($"ProtectedFeild: {prime.privateFeild}");
        // Console.WriteLine($"ProtectedFeild: {prime.protectedFeild}");

        prime.PublicMethod();
        prime.InternalMethod();
        // prime.PrivateMethod();
        // prime.ProtectedMethod();
    }
}