using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptioon_Handling_Assignment_2
{
    internal class Program
    {
        static void Main()
        {
            int userAge;
            Console.WriteLine("Enter your Age");

            try
            {
                userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    Console.WriteLine("Negitive and zero numbers are not allowed to calculate the date of year");
                }
                else
                {
                userAge = DateTime.Now.Year - userAge;
                Console.WriteLine("You year of birth is " + userAge.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
