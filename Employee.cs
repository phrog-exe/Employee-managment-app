using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
    public class Employee : IEmployee

    {
        
            public string Name { get; set; }
            public int Age { get; set; }

            protected Role role;

            public Employee(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name} \n" +
                    $"Age: {Age} \n" +
                    $"Role: {role}");
            }
        }
}
