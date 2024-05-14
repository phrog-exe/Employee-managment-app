using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
    public class Employee : IEmployee

    {
        //private Attribute
        private string _company = "Doofenshmirtz evil inc";

        public string Name { get; set; }
            public int Age { get; set; }           
          public Role Role { get; protected set; }

        //override constructor - gets name, age and setts default role to intern
        public Employee(string name, int age) : this(name, age, Role.Intern) { }

        public Employee(string name, int age, Role role)
            {
                Name = name;
                Age = age;
                Role = role;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine(
                    $"Name: {Name} \n" +
                    $"Age: {Age} \n"   +
                    $"Role: {Role}");

                    DisplayCompany();
            }
        //protected method - can only be called within the class or in inheriting classes
        protected void DisplayCompany()
        {
            Console.WriteLine($"Company: {_company}");
        }

    }
}
