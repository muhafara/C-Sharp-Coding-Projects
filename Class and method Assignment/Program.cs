using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************************************************************
             
             ********************************************************************************************************/

            Console.WriteLine("Enter the first number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            MathOperation.printIntegers(numOne, numtwo);

            /*******************************************************************************************************

             ********************************************************************************************************/

            Console.WriteLine("Enter the first number");
            int numOneOute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int numtwoOut = Convert.ToInt32(Console.ReadLine());
            int additionResult, subsResult, mulResult, divResult;
            MathOperation.printIntegers(numOneOute, numtwoOut, out additionResult, out subsResult, out mulResult, out divResult);
            Console.WriteLine($"First Number :{numOneOute} + SecondNumber {numtwoOut} = {additionResult}");
            Console.WriteLine($"First Number :{numOneOute} - SecondNumber {numtwoOut} = {subsResult}");
            Console.WriteLine($"First Number :{numOneOute} * SecondNumber {numtwoOut} = {mulResult}");
            Console.WriteLine($"First Number :{numOneOute} / SecondNumber {numtwoOut} = {divResult}");








            Console.Read();
        }
    }
}
