using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Method_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************************************************
             INTEGER OPERATION
             *****************************************************************************************************************/
            MathOperation mathopeartioninteger = new MathOperation();
            Console.WriteLine("The Math Operation Method for integer returns " + mathopeartioninteger.MathOperationMethod(4));

            /****************************************************************************************************************
              Decimal OPERATION
             *****************************************************************************************************************/

            MathOperation mathopeartiondecimal = new MathOperation();
            Console.WriteLine("The Math Operation Method for double returns " + mathopeartiondecimal.MathOperationMethod(46.5m));

            /****************************************************************************************************************
              STRING CONVERSION TO INTEGER
             *****************************************************************************************************************/

            MathOperation mathopeartionstring = new MathOperation();
            Console.WriteLine("The Math Operation Method for string returns " + mathopeartionstring.MathOperationMethod("10"));

            Console.Read();


        }
    }
}