using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Method_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          MathOperation mathoperation = new MathOperation();
            mathoperation.MathoperationMethod(3,5);

            Console.WriteLine("Enter the first number");
            int NumOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int NumTwo = Convert.ToInt32(Console.ReadLine());


            MathOperation mathoperationTwo = new MathOperation();
            mathoperation.MathoperationMethod(NumOne,NumTwo);



            Console.Read();
        }
    }
}
