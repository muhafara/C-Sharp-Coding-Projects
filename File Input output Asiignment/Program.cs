using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_Input_output_Asiignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Calling method to log number to file//
          logFileToDirectory();
        /*-----------------------------------------------------*/

          //Calling method to read number from log
          logFileReadDataDirectory();
          /*-----------------------------------------------------*/




            Console.Read();
        }

        /*******************************************************************************************************
            METHOD TO LOG FILE IN TO THE DIRRECTORY
         ********************************************************************************************************/

        public static void logFileToDirectory() {
            try
            {
                Console.WriteLine("Enter the number to log it as a file");
                int getNumber = Convert.ToInt32(Console.ReadLine());
                File.WriteAllText(@"C:\\Users\\faran\\Documents\\log.txt", getNumber.ToString());
                Console.WriteLine("File saved succesfully!");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Unable to find the path");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Enter an integer value");
            }
            catch
            {
                Console.WriteLine("Some thing went wrong while writing the file");
            }
        }


        /*******************************************************************************************************
            METHOD TO READ DATA FROM THE DIRECTORY
         ********************************************************************************************************/

        public static void logFileReadDataDirectory()
        {
            try
            {
                string getFileData = File.ReadAllText(@"C:\\Users\\faran\\Documents\\log.txt");
                int numConvert = Convert.ToInt32(getFileData);
                Console.WriteLine("The number from file is {0}", numConvert);
                Console.WriteLine("Number read succesfully!");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Unable to find the path");
            }
            catch
            {
                Console.WriteLine("Some thing went wrong while reading the file");
            }
        }


    }
}
