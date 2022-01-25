using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*******************************************************************************************************
               Input for both integer is taken by user
             ********************************************************************************************************/
            Console.WriteLine("Enter your first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            MathOperation mathoperation = new MathOperation();
            Console.WriteLine("The addition of two number is " + mathoperation.AdditionMethod(firstNumber,secondNumber));

            /*******************************************************************************************************
               Input for first integer taken by the user and second one is optional 
             *****************************************************************************************************/
            Console.WriteLine("Enter your first number, Second number is optional in this case");
            int firstOptionlNumber = Convert.ToInt32(Console.ReadLine());
            MathOperation mathoperationtwo = new MathOperation();
            Console.WriteLine("The addition of two number where as second number was optional " 
            + mathoperationtwo.AdditionOptionalMethod(firstOptionlNumber, secondNumber));

            /*******************************************************************************************************
               Using function to add integer for both first number and second number to default
             *****************************************************************************************************/
            Console.WriteLine("Addition using default numbers");
            MathOperation mathoperationdefault = new MathOperation();
            Console.WriteLine("The addition of two number where as both number was optional "
            + mathoperationtwo.AdditionOptionalMethod(firstOptionlNumber, secondNumber));










            Console.Read();
        }
    }
}
