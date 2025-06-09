/* using System;
namespace DotNetCourse
{
    // Base class
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double salary)
        {
            if (salary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            Name = name;
            Salary = salary;
        }

        // Operator overloading to add salaries of two employees
        public static double operator +(Employee e1, Employee e2)
        {
            return e1.Salary + e2.Salary;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }

    // Derived class: Manager
    public class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) { }
        public override void Display()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {Salary}");
        }
    }
    // Derived class: Developer
    public class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary) { }
        public override void Display()
        {
            Console.WriteLine($"Developer: {Name}, Salary: {Salary}");
        }
    }

    // Main App
    public static class RunApp
    {
        public static void Main()
        {
            try
            {
                Manager mgr = new Manager("Sunil", 50000);
                Developer dev = new Developer("Shrestha", 45000);
                mgr.Display();
                dev.Display();
                double totalSalary = mgr + dev;
                Console.WriteLine($"\nCombined Salary: {totalSalary}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }
}
 */