using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
     public class Assistant : Employee
    {
        public Assistant(string name, int age) : base(name, age)
        {
            role = Role.Assistant;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine("Assistant specific info...");
        }
    }
}
