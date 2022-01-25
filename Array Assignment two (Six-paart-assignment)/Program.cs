using System;
using System.Collections.Generic;

namespace Array_Assignment_two__Six_paart_assignment_
{
    internal class Program
    {
        //One dimentional array of the string
        static string[] myStringArray;

        //List of a string:
        static List<string> myListOfString = new List<string>() { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

        //List of a string containing duplicates values.
        static List<String> myDuplicateList = new List<string> { "john", "alex", "john", "david", "justin", "alex", "john" };


        static void Main()
        {
            /********************************************************************************************************************************************
               CONSOLE APP ASSIGNMNET PART 1 -- TAKING INPUT FOR STRING ARRAY
             **********************************************************************************************************************************************/
            Console.WriteLine("Please enter the length of an array");
            int stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            getStringArrayInput(stringArrayIndex);

            /********************************************************************************************************************************************
               CONSOLE APP ASSIGNMNET PART 1 -- PRINTING VALUES FOR STRING ARRAYS    
             **********************************************************************************************************************************************/
            Console.WriteLine("Printing values of a String Array");
            printStringArrayValues(myStringArray);


            /********************************************************************************************************************************************
              CONSOLE APP ASSIGNMNET PART 2 -- CREATING AN INFINITE WHILE LOOP
            **********************************************************************************************************************************************/
            infiniteLoopFunc();


            /********************************************************************************************************************************************
               CONSOLE APP ASSIGNMNET PART 3 -- " < " OPERATOR..
             **********************************************************************************************************************************************/
            int[] comparisionArray = new int[] { 2, 4, 6, 8, 10 };
            //using < operator for for each loop to determine the certain condition
            foreach (int counter in comparisionArray)
            {
                if (counter < comparisionArray.Length)
                {
                    Console.WriteLine("\nI'm a counter and my values is " + counter);
                }
            }
            int i  = 0;
            //using <= operator for for while loop to determine the certain condition
            while (i <= 5)
            {
                Console.WriteLine("\nCondition will be true untill i is <= 5");
                i++;
            }

            /********************************************************************************************************************************************
                    FUNCTION TO ITERATE THE WORD INSIDE THE LIST
             **********************************************************************************************************************************************/
            Console.WriteLine("Enter the world you would like to search");
            string getWord = Console.ReadLine();
            getWord.ToLower();
            searchArrayList(myListOfString, getWord);


            /********************************************************************************************************************************************
                    FUNCTION TO ITERATE THE WORD INSIDE THE DUPLICATE LIST
           **********************************************************************************************************************************************/
            Console.WriteLine("Enter the world you would like to search");
            string getSearchOne = Console.ReadLine();
            getSearchOne.ToLower();
            searchDuplicateArrayListSTring(myDuplicateList, getSearchOne);

            /********************************************************************************************************************************************
                    FOREACH LOOP TO ITERATE THE WORD INSIDE THE DUPLICATE LIST
            **********************************************************************************************************************************************/
            Console.WriteLine("Enter the world you would like to search");
            string getSearch = Console.ReadLine();
            getSearch.ToLower();
            iterationUsingforEach(myDuplicateList, getSearch);









            Console.Read();
        }

        /********************************************************************************************************************************************
         FUNCTION TO CREATE INFINITE LOOP AND FIXED THE LOOP
         **********************************************************************************************************************************************/
        public static void infiniteLoopFunc() {
            //Error in loop is that the value of i is not incrementes as I did't added statement for incrementation
            //to fix this issue: I need to add i ++ inside the body of loop..
/*            int i = 0;           
            while (i < 5) {
                Console.WriteLine(i);
            } */

             int i = 0;
            while (i < 5)
            {
                Console.WriteLine("\nThe value of i is " + i);
                i++;
            }
        }

/********************************************************************************************************************************************
 FUNCTION TO TAKE INPUT FOR ONE-DIMENTIONAL ARRAY OF STRING
 **********************************************************************************************************************************************/
public static void getStringArrayInput(int index)
        {
            myStringArray = new string[index];
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine("\nPlease enter the string to add value for string array");
                string myValue = Console.ReadLine();
                myStringArray[i] = myValue;
            }
        }

        /********************************************************************************************************************************************
         FUNCTION TO PRINT VLAUES FOR ONE-DIMENTIONAL ARRAY OF STRING
         **********************************************************************************************************************************************/
        public static void printStringArrayValues(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Index of an array is :" + i + " value corrosponding to the index is :" + stringArray[i]);
            }
        }


        /********************************************************************************************************************************************
          FUNCTION TO ITERATE THROUGHT THE ARRAYLIST WITHOUT DUPLICATES STRING VALUES
         **********************************************************************************************************************************************/
        public static void searchArrayList(List<string> mySearchList, string search)
        {

            for (int i = 0; i < mySearchList.Count; i++)
            {
                bool check = mySearchList[i].Equals(search);
                if ((i == mySearchList.Count - 1) && (!check))
                {
                    Console.WriteLine("Sorry! our list doest't contain the word you provided");
                }
                else if (!check)
                {
                    continue;
                }
                else if (check)
                {
                    Console.WriteLine("The given word " + search + " found at index " + i);
                    break;
                }

            }
        }

        /********************************************************************************************************************************************
          FUNCTION TO ITERATE THROUGHT THE ARRAYLIST WITH DUPLICATE STRING 
         ********************************************************************************************************************************************/
        public static void searchDuplicateArrayListSTring(List<string> mySearchList, string search)
        {
            List<int> recordIndex = new List<int>();
            int counter = 0;
            int i = 0;
            int getIndex = 0;
            string wordRecord = null;
            for (i = 0; i < mySearchList.Count; i++)
            {
                if (mySearchList[i].Equals(search))
                {
                    counter++;
                    recordIndex.Add(i);
                    wordRecord = mySearchList[i].ToString();
                    getIndex = i;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Sorry! our list doest't contain the word you provided");
            }
            else if (counter == 1)
            {
                Console.WriteLine("The given word found at index " + getIndex + "  and the word is " + wordRecord + "\nThis words appear only one time in the list");
            }

            else if (counter > 1)
            {
                for (int j = 0; j < recordIndex.Count; j++)
                {
                    Console.WriteLine("Indexes of duplicate word is : " + recordIndex[j]);
                }
                Console.WriteLine("The word is " + wordRecord);
            }

        }

        /********************************************************************************************************************************************
          ITERATION OF LOOP USING FOR-EACH LOOP
        **********************************************************************************************************************************************/
        public static void iterationUsingforEach(List<string> mySearchList, string search)
        {
            int counter = 0;
            int getIndex = 0;
            string wordRecord = null;
            foreach (string s in mySearchList)
            {
                if (s.Equals(search))
                {
                    counter++;
                    wordRecord = s;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Sorry! our list doest't contain the word you provided");
            }
            else if (counter >= 1)
            {
                Console.WriteLine("The given word is " + wordRecord + "\nit appears " + counter + " times in a list");
            }

        }
    }
    
}
