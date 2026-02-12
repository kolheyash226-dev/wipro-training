using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class que2
    {
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();   

            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }

        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    count++;
                }
            }

            Console.WriteLine("Total no. of Palindrome Words : " + count);
        }


    }
}
