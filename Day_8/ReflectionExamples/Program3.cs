using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsReflectionExample3;
using System.Reflection;

namespace ReflectionExamples
{
    internal class Program3
    {
        static void Main()
        {
            Type student = typeof(Student);
            Assembly assembly = Assembly.GetAssembly(student);

            Type[] types = assembly.GetTypes();

            foreach(Type type in types)
            {
                Console.WriteLine("Type Name is  " +type.Name);

                MethodInfo[] methodInfos = type.GetMethods();
                foreach(MethodInfo methodInfo in methodInfos)
                {
                    Console.WriteLine(methodInfo.Name);

                    ParameterInfo[] parameters = methodInfo.GetParameters(); 
                    foreach(ParameterInfo param in parameters)
                    {
                        Console.WriteLine("Param Name " +param.Name);
                    }
                }

                
            }
        }
    }
}
