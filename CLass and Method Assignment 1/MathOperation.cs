using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Method_Assignment_1
{
    internal class MathOperation
    {

        public int MathOperationMethod(int Number)
        {
            return Number += 2;
        }

        public int MathOperationMethod(decimal decimalNumber)
        {
            return Convert.ToInt32(Math.Round(decimalNumber));
        }

        public int MathOperationMethod(string StringNumber)
        {
            return Convert.ToInt32(StringNumber) * 2;
        }




    }
}