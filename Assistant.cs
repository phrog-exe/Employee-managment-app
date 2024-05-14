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
        public Assistant(string name, int age) : base(name, age, Role.Assistant)
        {
           
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine("\nJOB DESCRIPTION: \n");
            Console.WriteLine("An assistant is responsible for the smooth and efficient running of an office through performing administrative and clerical duties, " +
                "as well as providing reliable support for managers, staff, and office visitors. " +
                "An assistant is also known as an administrative assistant, office assistant, personal assistant, or office clerk.\n");
        }
    }
}
