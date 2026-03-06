using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class P3
    {
        [Obsolete("Deprecated Method",false)]
        public static void Testmethod()
        {
            Console.WriteLine("Hello World...");
        }
        static void Main()
        {
            Testmethod();
        }
    }
}
