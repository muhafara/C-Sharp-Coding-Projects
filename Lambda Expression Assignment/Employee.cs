using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public Employee() {
            this.EmployeeFirstName = "Joe";
        }

        public Employee(int empID, string elastname) : this(empID, "Joe" ,elastname)
        {
            this.EmployeeID = empID;
            this.EmployeeLastName = elastname;
        }

        public Employee(int empID, string efirstname, string elastname) {
            this.EmployeeID = empID;
            this.EmployeeFirstName = efirstname;
            this.EmployeeLastName = elastname;
}
    }
}
