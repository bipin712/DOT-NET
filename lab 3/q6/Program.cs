using System;
using System.Collections.Generic;
using System.Linq;

// Define Student class
class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

// Define Department class
class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 1: Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "John", DepartmentId = 101 },
            new Student { StudentId = 2, Name = "Alice", DepartmentId = 102 },
            new Student { StudentId = 3, Name = "Bob", DepartmentId = 101 },
            new Student { StudentId = 4, Name = "Emma", DepartmentId = 103 }
        };

        // Step 2: Create a list of departments
        List<Department> departments = new List<Department>
        {
            new Department { DepartmentId = 101, DepartmentName = "Computer Science" },
            new Department { DepartmentId = 102, DepartmentName = "Mathematics" },
            new Department { DepartmentId = 103, DepartmentName = "Physics" }
        };

        // Step 3: Join students with departments using LINQ
        var studentDepartments = from student in students
                                 join dept in departments
                                 on student.DepartmentId equals dept.DepartmentId
                                 select new
                                 {
                                     StudentName = student.Name,
                                     DepartmentName = dept.DepartmentName
                                 };

        // Step 4: Display results
        Console.WriteLine("Student Name - Department Name");
        foreach (var sd in studentDepartments)
        {
            Console.WriteLine($"{sd.StudentName} - {sd.DepartmentName}");
        }
    }
}

