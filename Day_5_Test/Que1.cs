using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    internal class Que1
    {


      
            static char FirstNonRepeating(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    bool isUnique = true;

                    for (int j = 0; j < s.Length; j++)
                    {
                        if (i != j && s[i] == s[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }

                    if (isUnique)
                        return s[i];
                }

                return '$';
            }
            static void Main()
            {
                Console.WriteLine("Enter The String: ");
                string s = Console.ReadLine();
                Console.WriteLine(FirstNonRepeating(s));
            }
        }
    }
