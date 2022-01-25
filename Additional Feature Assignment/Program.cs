using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Feature_Assignment
{
    internal class Program
    {
        private const decimal bonus = 2;

        static void Main(string[] args)
        {
            /*******************************************************************************************************
              Calling constructor with any default value
             ********************************************************************************************************/
            ConstructorChaining cc = new ConstructorChaining(12,"justin","smith","myemai@justin.com",350m);
            var balanceAfterBonus = cc.employeePay * bonus;

            Console.WriteLine("Employee Id : " + cc.employeeId + " Employee Name : " + cc.employeeName
            + " Employee Last Name : " + cc.employeeLastName
            + " Employee Email : " + cc.employeeEmail +"Employee pay with bonus is "+balanceAfterBonus);

            /*******************************************************************************************************
                Employee Id is default 
             ********************************************************************************************************/

            ConstructorChaining cc1 = new ConstructorChaining("john", "Alexander", "myemai@john.com");
            var balanceBeforeBonusTwo = cc1.employeePay * bonus;
            Console.WriteLine("Employee Id : " + cc1.employeeId + " Employee Name : " + cc1.employeeName
            + " Employee Last Name : " + cc1.employeeLastName
            + " Employee Email : " + cc1.employeeEmail + "Employee pay with bonus is " + balanceBeforeBonusTwo);


            Console.Read();

        }
    }
}
