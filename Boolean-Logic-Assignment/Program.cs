using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main()
        {
            int ageCheck;
            bool duiViolation;
            int numOfSpeedingTickets;
            Console.WriteLine("What is your age");
            ageCheck = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("have you ever had a DUI violation? Please specify as \"true\" or \"false\" ");    
            duiViolation = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you had?");
            numOfSpeedingTickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = (ageCheck >= 15 && duiViolation == false && numOfSpeedingTickets <= 3);
            Console.WriteLine("\nYou age is "+ageCheck);
            Console.WriteLine("\nDUI Violation "+duiViolation);
            Console.WriteLine("\nNumber of speeding tickets "+numOfSpeedingTickets);
            Console.WriteLine("Your qualification "+isQualified);
            Console.Read();
        }
    }
}
