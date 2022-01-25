using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Feature_Assignment
{
    internal class ConstructorChaining
    {

        public int employeeId { get; }
        public string employeeName { get; }
        public string employeeLastName { get;}
        public string employeeEmail { get; }
        public decimal employeePay { get;}

        //Setting default value to constructor if Id is not provide.

        public ConstructorChaining(string ename, string lname, string email) : this(301, ename, lname,email,400m) {
}

        public ConstructorChaining(int eid, string ename, string lname, string email, decimal epay) { 
        this.employeeId = eid;
        this.employeeName = ename;
        this.employeeLastName = lname;
        this.employeeEmail = email;
        this.employeePay = epay;
}



    }
}
