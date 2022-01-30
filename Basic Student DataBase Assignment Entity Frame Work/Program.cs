using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Student_DataBase_Assignment_Entity_Frame_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext()) {
                var stud = new Student() { StudentName = "Kyle" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("Succesfuuly added student");
                Console.Read();
        }
        }
    }
}
