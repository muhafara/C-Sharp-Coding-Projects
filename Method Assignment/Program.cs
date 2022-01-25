using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Math_Operation mathoperation = new Math_Operation();
            int myNum;
            Console.WriteLine("Enter the number for three maths operations");
            myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Method from Math operation Class for addition  "+mathoperation.Addnumber(+myNum));
            Console.WriteLine("Method from Math operation Class for substraction  " + mathoperation.Subnumber(myNum));
            Console.WriteLine("Method from Math operation Class for multiplication  " + mathoperation.Mulnumber(myNum));
            Console.Read();
            
            
        }
    }
}
