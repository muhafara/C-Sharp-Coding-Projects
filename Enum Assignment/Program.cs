using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    internal class Program
    {

        static void Main()
        {
            bool counter = false;
            Console.WriteLine("Enter the current day of the week");
            string CurrentDay = Console.ReadLine();
            foreach (myEnum day in Enum.GetValues(typeof(myEnum)))
            {
                String check = day.ToString();
                try
                {
                    if (CurrentDay.Equals(check))
                    {
                        Console.WriteLine(CurrentDay + " is a day of week");
                        counter = true;
                        break;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            if (!counter)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.Read();
        }


        public enum myEnum {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
         }
    }
}
