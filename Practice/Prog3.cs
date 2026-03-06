using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog3
    {
        static void Main()
        {
            string sname;
            string city;
            string company;
            Console.WriteLine("Enter Student Name  ");
            sname = Console.ReadLine();
            Console.WriteLine("Enter Student City   ");
            city = Console.ReadLine();
            Console.WriteLine("Enter Company   ");
            company = Console.ReadLine();
            Console.WriteLine("Student Name  " +sname);
            Console.WriteLine("Student City   " +city);
            Console.WriteLine("Student Company  " +company);
        }
    }
}
