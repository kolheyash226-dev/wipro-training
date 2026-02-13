using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class Question2
    {
        static bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }
            string str = sb.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string reverse = new string(arr);
            if (str != reverse)
            {
                return false;
            }
            return true;
        }
        static void Main()
        {
            Console.WriteLine("Enter The String :");
            string s = Console.ReadLine();
            Console.WriteLine(IsPalindrome(s));
        }
    }
}