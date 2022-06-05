using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Nkenchor_s_Class_
{
    public class Employee:Person
    {
        int empcode;

        public Employee(string Name, int empcode) : base(Name)
        {
            this.empcode = empcode;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name = " + this.Name + ", Employee Code = " + this.empcode);
        }

    }
}
