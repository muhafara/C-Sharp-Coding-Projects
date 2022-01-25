using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    internal class Employee : IQuittable
    {
        string FirstName;
        string LastName;

        public Employee() {
            this.FirstName = "John";
            this.LastName = "Alexander";
}
        public void Quit()
        {
           Console.WriteLine("The Employee name "+FirstName +" "+LastName + " quit");
        }
    }
}
