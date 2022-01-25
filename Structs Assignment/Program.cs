using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num1;
            num1.Amount = 43.65m;
            Console.WriteLine("The Amount is  " + num1.Amount);
            Console.Read();
        }
    }
}
