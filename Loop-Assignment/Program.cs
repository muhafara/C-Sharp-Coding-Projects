using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    internal class Program
    {
        static void Main()
        {
            int my_Value = 0;
            bool value_Checker = my_Value <= 0;
            while (value_Checker && my_Value <= 10)
            {
                my_Value++;
                Console.WriteLine(value_Checker);
            }

            // Boolean comparison using do while loop
            my_Value = 1;
            do
            {
                Console.WriteLine("Repeated untill value checker is true"); ;
                value_Checker = my_Value <= 10;
                my_Value++;
            } while (value_Checker);
        }
    }
}

