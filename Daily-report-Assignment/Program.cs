using System;
namespace Daily_report_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\tPitman Training");

            String courseName;
            int pageNumber;
            Boolean instructorSupport;
            String yourExperienceWithUs;
            String feedBack;
            float studyHours;

            Console.WriteLine("What course are you in?");
            courseName = Console.ReadLine();


            Console.WriteLine("What page number?");
            pageNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you need help with anything?  Please answer “true” or “false”");
            instructorSupport = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Were there any positive experiences you’d like to share?  Please provide specifics");
            yourExperienceWithUs = Console.ReadLine();


            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific");
            feedBack = Console.ReadLine();


            Console.WriteLine("How many hours did you study today");
            studyHours = Single.Parse(Console.ReadLine());


            ///////////////////////////Results according to your questions///////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!”");
            Console.WriteLine("\nThe Course you are in\t" + courseName +
            "\nPage Number \t" + pageNumber +
            "\nRequire additional help\t" + instructorSupport +
            "\nYour postive experience\t" + yourExperienceWithUs +
            "\nShare your feedback \t" + feedBack +
            "\nHour you study everyday\t" + studyHours
         );
            Console.Read();

        }
    }
}
