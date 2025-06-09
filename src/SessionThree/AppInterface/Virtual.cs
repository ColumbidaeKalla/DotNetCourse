namespace DotNetCourse.src.SessionThree.AppInterface;

using System;

public class User {
    //virtual method with implementation
    public virtual void Great() {
        Console.WriteLine("Hello from User class");
    }
}

public class AdminUser : User {
    public override void Great() {
        Console.WriteLine("Hello from AdminUser class");
    }
}

public class GuestUser : User {
    public override void Great() {
        Console.WriteLine("Hello from GuestUser class");
    }
}