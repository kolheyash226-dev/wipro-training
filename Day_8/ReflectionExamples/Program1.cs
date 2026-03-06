using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class Program1
    {
        static void Main()
        {
            Type type = typeof(string);
            foreach(MethodInfo methodInfo in type.GetMethods())
            {
                Console.WriteLine(methodInfo.Name);
            }
        }
    }
}
