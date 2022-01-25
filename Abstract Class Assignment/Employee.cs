using System;

namespace Abstract_Class_Assignment
{
    internal class Employee : Person
    {

        public Employee(string FirstName, string LastName) { 
                this.FirstName = FirstName;
                this.LastName = LastName;

}
        public override void sayName()
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);
        }
    }
}
