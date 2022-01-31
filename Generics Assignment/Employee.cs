using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Employee<T>
    {

        public Employee() { 
        this.things = new List<T>();
        }
        public List<T> things 
        {
            get;
            set;
        }    
    }
}
