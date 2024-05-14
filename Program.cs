using employee_managment_app;
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main(string[] args)
    {
        List<IEmployee> employees = new List<IEmployee>
        {
            new Manager("Alice", 35),
            new Assistant("John", 28),
            new Intern("Bob", 22)
        };

        foreach (var employee in employees)
        {
            employee.DisplayInfo();
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }


    }
}