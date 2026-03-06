using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class P5
    {
        [Obsolete("method is Obsolete",true)]
        static void Method1()
        {
            Console.WriteLine("This is method1");
        }

        static void Method2()
        {
            Console.WriteLine("This is method2");
        }

        static void Main()
        {
            //Method1(); // Will not compile as its Obsolte method
            Method2();

        }
    }
}
