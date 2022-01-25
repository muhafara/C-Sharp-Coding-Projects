using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_method_Assignment
{
    static class MathOperation
    {


        public static void printIntegers( int numOne, int numTwo) {
            Console.WriteLine("The data given is divide by two and results is :" + (numOne + numTwo) / 2);
}

        public static void printIntegers( int numOne, int numTwo, out int Addition, out int Substraction, out int Multiplication, out int Division)
        {
            Addition = numOne + numTwo;
            Substraction = numOne - numTwo;
            Multiplication = numOne * numTwo;
            Division = numOne / numTwo;

            if (numTwo != 0)
            {
                Division = numOne - numTwo;
            }
            else {
                Division = 0;
                Console.WriteLine("Division by zero is not allowed");
            }
        }


    }
}
