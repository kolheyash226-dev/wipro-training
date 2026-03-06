using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ClsReflectionExample3;

namespace ReflectionExamples
{
    internal class P1
    {
        static void Main()
        {
            Type type = typeof(string);
            // Use Reflection to find about
            // any sort of data related to t
            Console.WriteLine("Name : {0}", type.Name);
            Console.WriteLine("Full Name : {0}", type.FullName);
            Console.WriteLine("Namespace : {0}", type.Namespace);
            Console.WriteLine("Base Type : {0}", type.BaseType);

            Type studentType = typeof(Student);
            Console.WriteLine("Student Info....");
            Console.WriteLine("------------------");
            Console.WriteLine("Name : {0}", studentType.Name);
            Console.WriteLine("Full Name : {0}", studentType.FullName);
            Console.WriteLine("Namespace : {0}", studentType.Namespace);
            Console.WriteLine("Base Type : {0}", studentType.BaseType);
        }
    }
}
