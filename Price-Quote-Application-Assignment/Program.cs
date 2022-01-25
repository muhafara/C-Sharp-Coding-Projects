using System;

namespace Price_Quote_Application_Assignment
{
    internal class Program
    {
        static void Main()
        {
            float package_Weight;
            float package_Width;
            float package_Height;
            float package_lenght;
            double shipping_Estimated_Cost;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight:");
            package_Weight = Single.Parse(Console.ReadLine());
            if (package_Weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            } else {
                Console.WriteLine("Please enter the package width:");
                package_Width = Single.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                package_Height = Single.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                package_lenght = Single.Parse(Console.ReadLine());
                float dimension_Check = package_Width + package_Height + package_lenght;
                if (dimension_Check > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else {
                    float get_dimension = package_Width * package_Height * package_lenght;
                    shipping_Estimated_Cost = (get_dimension * package_Weight) / 100;
                    Console.WriteLine("\nPackage weight "+package_Weight); 
                    Console.WriteLine("\nPackage height " + package_Height);
                    Console.WriteLine("\nPackage length " + package_lenght);
                    Console.WriteLine("\nYou Estimated total for shipping this package is :$" + shipping_Estimated_Cost+".00");

                }
            }
            
        }
    }
}
