using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

// Assembly-level attribute MUST be outside namespace
[assembly: CLSCompliant(true)]
namespace ReflectionExamples
{

    public class P6
    {
        public void HelloWorld()
        {
        }
        //error because methods differ only in their case
        public void HELLOWORLD()
        {
        }

        static void Main()
        {

            Console.WriteLine("Welcome to Reflection...");
        }
    }
}
