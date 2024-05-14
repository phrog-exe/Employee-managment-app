using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
    public class Intern : Employee
    {
        public Intern(string name, int age) : base(name, age)
        {
            role = Role.Intern;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Clerk specific info...");
        }
    }
}
