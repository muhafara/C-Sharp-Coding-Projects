using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Student_DataBase_Assignment_Entity_Frame_Work
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set;}
        public DateTime? DateofBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
}
    }

