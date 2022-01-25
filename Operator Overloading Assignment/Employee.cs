using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    internal class Employee
    {
       public int Employeeid;


        public Employee(int eId) { 
        this.Employeeid = eId;

}


        public static bool operator == (Employee e1, Employee e2)
        {
            return true;
}
        public static bool operator !=(Employee e1, Employee e2)
        {
            return false;
        }


    }
}
