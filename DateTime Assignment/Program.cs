using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter the number in 24 hour format");
            int getHour = Convert.ToInt32(Console.ReadLine());
            int x = getHour + DateTime.Now.Hour;


            if (x < 24)
            {
                Console.WriteLine("The exact time it will be in "+x + " : " +DateTime.Now.Minute + " : " +DateTime.Now.Second);
            }
            else if (x == 24)
            {
            Console.WriteLine("The exact time it will be in 00"  + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second);
            }
            else if (x > 24) 
            {
            Console.WriteLine("The exact time it will be in " + (x-24) + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second);
            }
            Console.Read();
        }
    }
}
