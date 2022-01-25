using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Employee employee = new Employee("Sample","Student");
            employee.sayName();
            Console.Read();
        }
    }
}
