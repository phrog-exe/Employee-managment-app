using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
     class Manager : Employee
    {
        public Manager(string name, int age) : base(name, age)
        {
            role = Role.Manager;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine("\nJOB DESCRIPTION:\n");

            Console.WriteLine("Managers ensure that their assigned department, store, or district is well staffed and provisioned, " +
                "adheres to quality and service standards, increases revenue and market share, " +
                "and helps the business accomplish its goals. " +
                "They hire and train employees, help develop and implement business strategies, " +
                "and perform a variety of other tasks to ensure the business is thriving." +"\n");
        }
    }
}
