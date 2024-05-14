using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace employee_managment_app
{
   public interface IEmployee
    {
        string Name { get; set; }
        int Age { get; set; }
        Role Role { get; }
        void DisplayInfo();
    }
}
