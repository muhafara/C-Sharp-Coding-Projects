using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignmentt
{
    internal class Program
    {

        static List<int> myList = new List<int>() {2, 4 , 5, 6 ,7, 3, 8 };

        static void Main()
        {
 
            /****************************************************************************************************
                DIVIDING INTEGER OF A LIST BY USER INPUT
             ****************************************************************************************************/

            try
            {
                Console.WriteLine("Enter the number you would to divide all the integer of a list");

                int getValue = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine("The intger at index  " + i + " value  " + myList[i] + " divided by " + getValue + " result  :" + myList[i] / getValue);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Integer can't be divided by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Integer can't be divide by string. Please type a whole number");
            }

            Console.Read();

}
        }
    }

