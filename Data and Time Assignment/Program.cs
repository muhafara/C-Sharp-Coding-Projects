using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_and_Time_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is\n" + DateTime.Now);
            var getTime = DateTime.Now.Hour;
            Console.WriteLine("Enter the time in 24 hour clock");
            int getHour = Convert.ToInt32(Console.ReadLine());
            if (getHour >= 0 && getHour <= 23)
            {
                if (getHour >= getTime)
                {
                    getHour -= getTime;
                    Console.WriteLine("the exact time it will be in " + getHour + "  hours");
                }
                else if (getHour < getTime) {

                    getHour = (24 - getTime) + getHour;
                    Console.WriteLine("the exact time it will be in " + getHour + "  hours");
                }
            }
            else {
                Console.WriteLine("Hours should be between 0 and 23");
            }
            Console.Read();
        }
    }
}
