using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The time now is: " + DateTime.Now);
            Console.WriteLine("Enter a number");
            int getHour = Convert.ToInt32(Console.ReadLine());
            DateTime x = DateTime.Now.AddHours(getHour);

            Console.WriteLine("The time in " + getHour + " hours will be: " + x);
        }
    }
}
