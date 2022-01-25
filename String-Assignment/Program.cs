using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main()
        {
            String first_String = "John";
            String second_String = "David";
            String third_String = "Jessie";
            Console.WriteLine("Concatination of three string "+String.Concat(first_String,second_String,third_String));
            Console.WriteLine("Concatination of three string using \"+\" "+first_String + " "+ second_String +" "+ third_String );
            Console.WriteLine("Converting String into upper case! "+first_String.ToUpper());
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello, My name is Faran!.");
            stringBuilder.Append("\nI'm currentl learning .net Frame work using console based app");
            stringBuilder.Append("\nMy instituation name is Pitman ");
            Console.Write(stringBuilder.ToString());
            Console.Read();
        }
    }
}
