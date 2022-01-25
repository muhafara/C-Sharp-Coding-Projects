using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_operator_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myMultiplocationNumber;
            Console.WriteLine("Enter your number to multiply with 50");
            myMultiplocationNumber = Convert.ToInt32(Console.ReadLine());
            myMultiplocationNumber *= 50;
            Console.WriteLine(myMultiplocationNumber);


            int myAdditionNumber;
            Console.WriteLine("Enter your number to add 25 with");
            myAdditionNumber = Convert.ToInt32(Console.ReadLine());
            myAdditionNumber += 25;
            Console.WriteLine(myAdditionNumber);


            double myDivisionNumber;
            Console.WriteLine("Enter your number to be divide by 12.5");
            myDivisionNumber = Convert.ToDouble(Console.ReadLine());
            myDivisionNumber /= 12.5;
            Console.WriteLine(myDivisionNumber);


            int myNumCheck;
            Boolean myBoolean = false;
            Console.WriteLine("Enter your number to check if it is greater than 50 ");
            myNumCheck = Convert.ToInt32(Console.ReadLine());
            if (myNumCheck > 50)
            {
                myBoolean = true;
            }
            Console.WriteLine(myBoolean);


            double myRemainderNumber;
            Console.WriteLine("Enter your number to see remainder with 7");
            myRemainderNumber = Convert.ToDouble(Console.ReadLine());
            myRemainderNumber %= 7;
            Console.WriteLine(myRemainderNumber);
            Console.Read();
        }
    }
}
