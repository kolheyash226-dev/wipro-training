using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class LambdaExample1
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>()
            {
                 new Employ{Empno=1,Name="Tushar",Dept="Dotnet",Desig="Manager",Basic=83234},
                 new Employ{Empno=2,Name="Abhishek",Dept="Java",Desig="Expert",Basic=99911},
                 new Employ{Empno=3,Name="Kabir",Dept="Sql",Desig="Developer",Basic=78822},
                 new Employ{Empno=4,Name="Shaik",Dept="Dotnet",Desig="Manager",Basic=89911},
                 new Employ{Empno=5,Name="Karthik",Dept="Java",Desig="Expert",Basic=91103},
                 new Employ{Empno=6,Name="Pranav",Dept="Dotnet",Desig="Developer",Basic=99323},
            };

            var result1 = employList.Select(x => x);
            Console.WriteLine("Employ List is ");
            foreach(var v in result1)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Enter Employ Number  ");
            int empno = Convert.ToInt32(Console.ReadLine());
            //var result2 = employList.Where(x => x.Empno == empno);
            Employ employ = employList.Where(x => x.Empno == empno).FirstOrDefault();
            if (employ!=null)
            {
                Console.WriteLine(employ);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }

            /* Implement Projection */
            var projection = employList.Select(x => new { x.Empno, x.Name, x.Basic });
            Console.WriteLine("Projected Fields are ");
            foreach(var v in projection)
            {
                Console.WriteLine($"Employ No {v.Empno} Employ Name {v.Name}  Basic {v.Basic}");
            }

            /* Filter w.r.t. Dept-wise */

            Console.WriteLine("Enter Department  ");
            string dept = Console.ReadLine();
            var deptData = employList.Where(x => x.Dept == dept);
            foreach(var v in deptData)
            {
                Console.WriteLine(v);
            }

            var sortedData = employList.Select(x =>x).OrderBy(x => x.Name).ToList();
            Console.WriteLine("Sort-By Name is  ");
            foreach(var v in sortedData)
            {
                Console.WriteLine(v);
            }

            var sortByBasic = employList.Select(x => x).OrderByDescending(x => x.Basic).ToList();
            Console.WriteLine("Sort-By Basic Descending Order  ");
            foreach(var v in sortByBasic)
            {
                Console.WriteLine(v);
            }
        }
    }
}
