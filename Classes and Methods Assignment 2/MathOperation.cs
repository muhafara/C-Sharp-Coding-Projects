using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    internal class MathOperation
    {
        public int AdditionMethod(int numOne, int numTwo) {
            return numOne + numTwo;
}

        public int AdditionOptionalMethod(int numOne = 2, int numTwo = 3)
        {
            return numOne + numTwo;
        }
    }
}
