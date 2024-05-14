using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
    public class Intern : Employee
    {
        public Intern(string name, int age) : base(name, age, Role.Intern)
        {
            
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("\nJOB DESCRIPTION:\n");
            Console.WriteLine("Interns assist the company with tasks set out by various teams, such as research," +
                " data capturing and working closely with different team members to learn more about the company.\n");
        }
    }
}
