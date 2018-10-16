using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyndrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Kolok";
            word = word.ToLower();
            bool result = true;
            if (word.Length % 2 == 0)
            {
                Console.WriteLine("your word has a pair number of letters, so it is not a palindrome");
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (int i = 0; i < (word.Length - 1) / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    result = false;
                }
            }
            if (result)
            {
                Console.WriteLine("your word is a palindrome");
            }
            if (!result)
            {
                Console.WriteLine("your word is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
