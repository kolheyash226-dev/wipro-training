using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    internal class Question3
    {

        static string Remo(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            int[] count = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);


                int idx = sb.Length - 1;
                if (idx > 0 && sb[idx] == sb[idx - 1])
                {
                    count[idx] = count[idx - 1] + 1;
                }
                else
                    count[idx] = 1;
                if (count[idx] == k)
                {
                    sb.Remove(sb.Length - k, k);

                }
            }
            return sb.ToString();
        }
        static void Main()
        {
            Console.WriteLine("Enter The string:");
            string s=Console.ReadLine();
            Console.WriteLine("Enter The No.");
            int k = Convert.ToInt32(Console.ReadLine());
            string result = Remo(s, k);
            Console.WriteLine("Reduced String: " + result);
        }
    }
}
