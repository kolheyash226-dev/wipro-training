using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog10
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + --x + ++x + ++x + x-- + --x;
            // Actual 10 + 10 + 11 + 12 + 12 + 10
            // Memory 11   10   11   12   11   10
            Console.WriteLine(y); //65
        }
    }
}
