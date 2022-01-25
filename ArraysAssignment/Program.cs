using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysAssignment
{
    class Program
    {

        //String array
        static string[] stringMyArray;
        //Int array
        static int[] intMyArray;
        //List of String
        static List<string> myDictionary = new List<string>();
        static void Main()
        {
            //One-dimensional array for string and its corresponding value

            Console.WriteLine("------------------------------------------------------------------------------------");
            addValueForStringArray();
            Console.WriteLine("Please enter the index to see the corresponding value");
            getStringArrayIndex(stringMyArray, getStringArrayIndex());
            Console.WriteLine("------------------------------------------------------------------------------------");

            //One-dimensional array for Integer and its corresponding value

            addValueForIntegerArray();
            Console.WriteLine("Please enter the index to see the corresponding value");
            getIntegerArrayIndex(intMyArray, getIntegerArrayIndex());
            Console.WriteLine("------------------------------------------------------------------------------------");


            //Array List
            addWordsDictionary(myDictionary);
            Console.WriteLine("Please enter the index to see the corresponding value");
            getListOfString(myDictionary, getArrayListIndex());
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.Read();

        }



        //Function to add value for String array
        public static void addValueForStringArray()
        {
            Console.WriteLine("Please Enter the size of an String array");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            stringMyArray = new string[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("\nEnter the string value to add");
                string addValues = Console.ReadLine();
                stringMyArray[i] = addValues;
            }

        }


        //Function to add value for Integer array
        public static void addValueForIntegerArray()
        {
            Console.WriteLine("Please Enter the size of an Integer array");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            intMyArray = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("\nEnter the integer value to add");
                string addValues = Console.ReadLine();
                intMyArray[i] = Convert.ToInt32(addValues);
            }

        }


        //Function to add words inside dictionary
        public static void addWordsDictionary(List<String> list)
        {
            Boolean loopChecker = true;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*******************Please type exit when you done with your list****************************************");
            while (loopChecker)
            {
                Console.WriteLine("\nEnter the new word to add into your dictionary");
                string word = Console.ReadLine();
                if (word.Equals("exit"))
                {
                    loopChecker = false;
                }
                else
                {
                    list.Add(word);
                }
            }
        }       

            /*----------------------------------ADD DATA FUNCTIONS ENDS-------------------------------------------------------*/



            /*----------------------------------FUNCTION TO PRINT ARRAY'S VALUES    -------------------------------------------------------*/


            //Function to print values of Integer array based on index
            public static void getIntegerArrayIndex(int[] myArray, int index)
        {
            int[] myIntegerArray = myArray.ToArray();
            Console.WriteLine("The value corrospending to the index " + index + " is : " + myIntegerArray[index]);
        }

        //Function to print values of String array based on index

        public static void getStringArrayIndex(String[] myArray, int index)
        {
            String[] myStringArray = myArray.ToArray();
            Console.WriteLine("The value corrospending to the index " + index + " is : " + myStringArray[index]);
        }

        //Function to get Array List
        public static void getListOfString(List<String> list, int index)
        {
            Console.WriteLine("The value corresponding to the index " + index + " is : " + list[index]);
        }

        /*----------------------------------FUNCTION TO PRINT ARRAY'S VALUES END-------------------------------------------------------*/


        /*----------------------------------    FUNCTION TO VARIFIES THE INDEX OF ARRAYS-------------------------------------------------------*/

        //Function to verify length of Integer array
        public static int getIntegerArrayIndex()
        {
            int index;
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= intMyArray.Length)
            {
                Console.WriteLine("Index does't exist\nProgrma is termnated");
                Console.Read();
                Environment.Exit(0);

            }
            return index;

        }

        //Function to verify length of String array
        public static int getStringArrayIndex()
        {
            int index;
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= stringMyArray.Length)
            {
                Console.WriteLine("Index does't exist\nProgrma is termnated");
                Console.Read();
                Environment.Exit(0);
            }
            else if(index < stringMyArray.Length)
            {
                return index;
            }
            return index;
        }

        //Function to verify length of Array list
        public static int getArrayListIndex()
        {
            int index;
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= myDictionary.Count)
            {
                Console.WriteLine("Index does't exist\nProgrma is termnated");
                Console.Read();
                Environment.Exit(0);
            }
            return index;

        }

    }
}





