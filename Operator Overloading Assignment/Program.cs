using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(123);

            Employee e2 = new Employee(1233);
            Console.WriteLine("Checking equality using boolean type true or false");
            Console.WriteLine(e1.Employeeid == e2.Employeeid);

            Console.Read();


        }
    }
}
