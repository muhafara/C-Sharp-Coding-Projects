using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Program
    {  
        static void Main()
        {

            Employee<string> employeeName = new Employee<string>();
            employeeName.things.Add("John");
            employeeName.things.Add("Justin");
            employeeName.things.Add("Ben");
            foreach (var item in employeeName.things)
            {
                Console.WriteLine("The List of string is " + item);
            }

            Console.WriteLine("List of integer");


            Employee<int> employeeID = new Employee<int>();
            employeeID.things.Add(123);
            employeeID.things.Add(456);
            employeeID.things.Add(765);
            foreach (var item in employeeID.things)
            {
                Console.WriteLine("The List of Integer is " + item);
            }

            Console.Read();
        }
    }
}
