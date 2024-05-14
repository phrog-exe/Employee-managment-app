using employee_managment_app;
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main(string[] args)
    {
        Manager manager1 = new Manager("John", 35);
        Assistant assistant1 = new Assistant("Alice", 28);
        Intern intern1 = new Intern("Bob", 40);


        // Displaying employee information
        manager1.DisplayInfo();
        assistant1.DisplayInfo();
        intern1.DisplayInfo();

        // Adding employees to a list
        List<IEmployee> employees = new List<IEmployee>();
        employees.Add(manager1);
        employees.Add(assistant1);
        employees.Add(intern1);

        // Displaying information of employees in the list
        Console.WriteLine("\nList of Employees:");
        foreach (var employee in employees)
        {
            employee.DisplayInfo();
        }


    }
}