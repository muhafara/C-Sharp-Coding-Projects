﻿using System;
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




        static void Main(string[] args){
            /*           ******************************************************************************************************
                            LIST OF 10 EMPLOYEE, TWO EMPLOYEES NAME "JOE"
                         ********************************************************************************************************/
            /*TenEmployee.Add(new Employee(1, "Joe", "Smith"));
            TenEmployee.Add(new Employee(2, "Alex", "Mathew"));
            TenEmployee.Add(new Employee(3, "Justin", "C"));
            TenEmployee.Add(new Employee(4, "Keyle", "Josheph"));
            TenEmployee.Add(new Employee(5, "Thomas", "Anthony"));
            TenEmployee.Add(new Employee(6, "Charles", "William"));
            TenEmployee.Add(new Employee(7, "Joe", "Charles"));
            TenEmployee.Add(new Employee(8, "Adam", "Zakaraya"));
            TenEmployee.Add(new Employee(9, "Aliyan", "james"));
            TenEmployee.Add(new Employee(10, "Stephen", "Brian"));


            foreach (var list in TenEmployee)
            {
                Console.WriteLine("\nEmployee id " + list.EmployeeID + "  Employee First Name : " + list.EmployeeFirstName +
                                "  Employee Last Name " + list.EmployeeLastName);
            }*/
            /*******************************************************************************************************
                    LIST OF EMPLOYEE USING FOREACH LOOP, FIRST NAME JOE
             ********************************************************************************************************/

            //Hi instructor this is the point where I need help with.
            //I'm trying to create a list using foreach loop
            foreach (var list in EmployeesListFirstNameJoe)
            {
                EmployeesListFirstNameJoe.Add(new Employee());
                Console.WriteLine(list);
            }

























            Console.Read();
        }


     

        public static void PrintEmployeeList(List<Employee> list)
        {
            foreach (var employee in list) {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("Employee ID :" + employee.EmployeeID + "\nEmployee Name :" + employee.EmployeeFirstName +
                                    "\nEmployee Last Name :" + employee.EmployeeLastName);
                Console.WriteLine("*************************************************************");
            }
        }
    }
}
