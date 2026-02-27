using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCalculation
{
    internal class GenExample1
    {
        public static void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
        static void Main()
        {
            int a = 5, b = 7;
            Console.WriteLine($"A value {a} B value {b}");
            Swap(ref a, ref b);
            Console.WriteLine("Data After Swapping...");
            Swap(ref a, ref b);
        }
    }
}
