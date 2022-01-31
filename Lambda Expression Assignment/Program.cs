using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    internal class Program
    {
        /*******************************************************************************************************
            LIST OF 10 EMPLOYEE NOTE: TWO EMPLOYEE SHOULD HAVE FIRST NAME "JOE"
         ********************************************************************************************************/
        static List<Employee> TenEmployee = new List<Employee>();


        /*******************************************************************************************************
             LIST OF EMPLOYEE HAVING FIRST NAME "JOE"
          ********************************************************************************************************/
        static List<Employee> EmployeesListFirstNameJoe = new List<Employee>();

        /*******************************************************************************************************
             LIST OF EMPLOYEE HAVING FIRST NAME "JOE" USING LAMBDA EXPRESSION
          ********************************************************************************************************/
        static List<Employee> EmployeesListFirstNameJoeUsingLambda = new List<Employee>();




        static void Main(string[] args) {
            /*******************************************************************************************************
                    LIST OF 10 EMPLOYEE, TWO EMPLOYEES NAME "JOE"
            ********************************************************************************************************/
            TenEmployee.Add(new Employee(1, "Joe", "Smith"));
            TenEmployee.Add(new Employee(2, "Alex", "Mathew"));
            TenEmployee.Add(new Employee(3, "Justin", "C"));
            TenEmployee.Add(new Employee(4, "Keyle", "Josheph"));
            TenEmployee.Add(new Employee(5, "Thomas", "Anthony"));
            TenEmployee.Add(new Employee(6, "Charles", "William"));
            TenEmployee.Add(new Employee(7, "Joe", "Charles"));
            TenEmployee.Add(new Employee(8, "Adam", "Zakaraya"));
            TenEmployee.Add(new Employee(9, "Aliyan", "james"));
            TenEmployee.Add(new Employee(10, "Stephen", "Brian"));

            //Comment the foreach to print the list of ten emloyee

            /*foreach (var list in TenEmployee)
            {
                Console.WriteLine("\nEmployee id " + list.EmployeeID + "  Employee First Name : " + list.EmployeeFirstName +
                "  Employee Last Name " + list.EmployeeLastName+"\n");
            }*/
            /*******************************************************************************************************
                    LIST OF EMPLOYEE USING FOREACH LOOP, FIRST NAME JOE
             ********************************************************************************************************/

            Console.WriteLine("\nUsing foreach loop to add employee with name JOE\n");
            foreach (var list in TenEmployee)
            {
                if (list.EmployeeFirstName.Equals("Joe")) {
                    EmployeesListFirstNameJoe.Add(list);
                }
            }


            /*******************************************************************************************************
                 PRINTING THE LIST OF THE EMPLOYEE WITH THE NAME JOE
             ********************************************************************************************************/

            Console.WriteLine("\nUsing foreach loop to print employee with first name JOE\n");
            foreach (var list in EmployeesListFirstNameJoe)
            {
                Console.WriteLine("\nEmployee id " + list.EmployeeID + "  Employee First Name : " + list.EmployeeFirstName +
                                "  Employee Last Name " + list.EmployeeLastName);
            }

            /*******************************************************************************************************
                    USING LAMBDA EXPRESSION TO ADD EMPLOYEE WITH THE NAME JOE TO A NEW LIST
             ********************************************************************************************************/
            Console.WriteLine("\nUsing foreach loop to add employee with name JOE using lambda exprssion\n");
            TenEmployee.ForEach(x => { if (x.EmployeeFirstName.Equals("Joe")) { EmployeesListFirstNameJoeUsingLambda.Add(x); } });


            /*******************************************************************************************************
                    USING LAMBDA EXPRESSION TO MAKE A LIST OF ALL EMPLOYEES WITH ID NUMBER GREATER THAN 5
             ********************************************************************************************************/
            EmployeesListFirstNameJoeUsingLambda.ForEach(x => {
                if (x.EmployeeID > 5)
            { Console.WriteLine("Employee id " + x.EmployeeID + 
                " Employee Name: " + x.EmployeeFirstName + 
                " Employee Last Name: " + x.EmployeeLastName);
                }
            });
            Console.Read();
        }
    }
}
