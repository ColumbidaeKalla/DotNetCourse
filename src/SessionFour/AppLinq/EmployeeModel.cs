using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCourse.src.SessionFour.AppLinq;

public class EmployeeModel
{
    public int Id { get; set; }
    public string Names { get; set; }
    public decimal Salary { get; set; }

    public EmployeeModel(int id, string name, decimal salary)
    {
        this.Id = id;
        this.Names = name;
        this.Salary = salary;
    }
}