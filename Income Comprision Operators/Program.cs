using System;

namespace Income_Comprision_Operators
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            decimal pOneHourlyRate;
            decimal pOneWeeklyHour;
            decimal pTwoHourlyRate;
            decimal pTwoWeeklyHour;
            decimal pOneAnnualSalary;
            decimal pTwoAnnualSalary;
            bool isPOneEarningMore = true;


            ////////////////Person One/////////////////////////
            Console.WriteLine("Enter person one hourly rate");
            pOneHourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter person one weekly hours");
            pOneWeeklyHour = Convert.ToDecimal(Console.ReadLine());
            /////////////////END/////////////////////////////////////

            ////////////////Person two/////////////////////////
            Console.WriteLine("Enter person two hourly rate");
            pTwoHourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter person two weekly hours");
            pTwoWeeklyHour = Convert.ToDecimal(Console.ReadLine());
            /////////////////END/////////////////////////////////////
            ///

            pOneAnnualSalary = (pOneWeeklyHour * pOneHourlyRate) * 52;
            Console.WriteLine("Annual salary of Person 1: \n"+pOneAnnualSalary);

            pTwoAnnualSalary = (pTwoWeeklyHour * pTwoHourlyRate) * 52;
            Console.WriteLine("Annual salary of Person 2: \n"+pTwoAnnualSalary);

            Console.WriteLine("Person 1 makes more money than Person 2");

            if (pTwoAnnualSalary > pOneAnnualSalary)
            {
                isPOneEarningMore = false;
                Console.WriteLine(isPOneEarningMore);
            }
            else {
                Console.WriteLine(isPOneEarningMore);
}
        }
    }
}
