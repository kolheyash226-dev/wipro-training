using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClsReflectionExample1;

namespace ReflectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            Console.WriteLine("Methods in Student Class are");
            foreach(MethodInfo method in type.GetMethods())
            {
                Console.WriteLine($"Method Name {method.Name}");
            }

            Console.WriteLine("Fields avaialble are  ");
            foreach(FieldInfo field in type.GetFields())
            {
                Console.WriteLine($"Field Name  {field.Name}");
            }
        }
    }
}
