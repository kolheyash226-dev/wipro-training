using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class que1
    {
        static void Main()
        {
            Console.WriteLine("Enter The Sentence");
            String sentence = Console.ReadLine();

            String[] words = sentence.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {

                
                        if (i % 2 == 1)
                        {
                            for (int j = words[i].Length - 1; j >= 0; j--)
                            {
                                Console.Write(words[i][j]);
                            }
                        }
                        else
                        {
                            Console.Write(words[i]);
                        }

                        Console.Write(" ");

            }

        }
    }
}
