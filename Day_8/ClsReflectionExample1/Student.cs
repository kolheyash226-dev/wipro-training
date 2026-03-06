using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsReflectionExample1
{
    public class Student
    {
        public string name;
        public double basic;
        public int empno;

        public void ShowEmploy()
        {
            Console.WriteLine("From Employ Method...");
        }

        public void ReadEmploy()
        {
            Console.WriteLine("From ReadyEmploy Method...");
        }
    }

}
