namespace DotNetCourse.src.SessionFour.AppLinq;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

// using DotNetCourse.src.SessionFour.AppLinq;

public class RunAppLinq
{
    public static void FilterEmployee()
    {
        List<EmployeeModel> employees = [
            new EmployeeModel(1, "Sunil", 5000),
            new EmployeeModel(2, "Ram", 6000),
            new EmployeeModel(3, "Roman", 8000),
            new EmployeeModel(4, "Suroj", 9000)
        ];

        var highSalaryEmployees = from e in employees
                                  where e.Salary > 6000
                                  select new { e.Names, e.Salary };

        Console.WriteLine("Name\t\tSalary");
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"{emp.Names}\t\t{emp.Salary}");
        }
    }

    //Using agregate functions to get statistics from a list of student marks
    public static void GetStats()
    {
        List<int> studentMarks = [85, 90, 78, 92, 88, 10, 44];

        int totalMarks = studentMarks.Sum();
        int lowestMark = studentMarks.Min();
        int highestMark = studentMarks.Max();
        int markCount = studentMarks.Count();

        Console.WriteLine($"Highest Mark: {highestMark}");
        Console.WriteLine($"Lowest Mark: {lowestMark}");
        Console.WriteLine($"Sum of Marks: {totalMarks}");
        Console.WriteLine($"Number of marks: {markCount}");
    }

    public static void JoinList()
    {
        List<string> name = ["Sunil", "Roman", "Suroj"];
        List<string> address = ["Kathmandu", "Bhaktapur", "Lalitpur", "Bhaktapur"];

        var concatReasult = name.Concat(address);

        Console.Write("Concate result >> ");
        foreach (string result in concatReasult) Console.Write($"{result} ");
        Console.WriteLine();

        var unionResult = name.Union(address);

        Console.Write("Union result >> ");
        foreach (string result in unionResult) Console.Write($"{result} ");
        Console.WriteLine();
    }

    public static void LinqJoin()
    {
        List<EmployeeModel> employees =
        [
            new EmployeeModel(1, "Sunil", 5000),
            new EmployeeModel(2, "Ram", 6000),
            new EmployeeModel(3, "Roman", 8000),
            new EmployeeModel(4, "Suroj", 9000)
        ];

        List<AddressModel> employeeAddress = [
            new AddressModel(100, "Kathmandu", 1, "Thamel"),
            new AddressModel(101, "Bhaktapur", 2, "Changunarayan"),
            new AddressModel(102, "Lalitpur", 3, "Pulchowk"),
            new AddressModel(103, "Bhaktapur", 4, "Bhadgaon")
        ];

        var result = from emp in employees
                    join add in employeeAddress on emp.Id equals add.EmployeeId
                    where emp.Salary > 6000
                    select new { emp.Names, emp.Salary, add.City, add.StreetName };
        
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Names} earns {item.Salary} and lives in {item.City}, {item.StreetName}");
        }
    }
}