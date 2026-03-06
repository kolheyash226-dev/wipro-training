using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog8
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + ++x;

            //Actual  10 + 12
            //Memory  11   12
            Console.WriteLine(y);
        }
    }
}
