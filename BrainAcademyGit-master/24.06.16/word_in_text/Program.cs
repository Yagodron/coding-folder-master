using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sadasdasfcaksdaf pie asdfsf sdafasdfergh  evnjfen lijvbidwkj k ihabv liah jh";
            string word = "pie";
            int count = 0;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == word[count])
                {
                    count++;
                }
                else 
                {
                    count = 0;
                }
                if (count == word.Length)
                {
                    Console.WriteLine("you have found the {0}", word);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("the {0} is a lie", word);
            Console.ReadKey();

        }
    }
}
