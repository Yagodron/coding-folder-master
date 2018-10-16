using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int[]> dictionary = new Dictionary<char, int[]>();
            dictionary.Add('a', new int[2] {0,1});
            dictionary.Add('b', new int[4] { 1, 0, 0, 0 });
            dictionary.Add('c', new int[4] { 1, 0, 1, 0 });
            dictionary.Add('d', new int[3] { 1, 0, 0 });
            dictionary.Add('e', new int[1] { 0 });
            dictionary.Add('f', new int[4] { 0, 0, 1, 0 });
            dictionary.Add('g', new int[3] { 1, 1, 0 });
            dictionary.Add('h', new int[4] { 0, 0, 0, 0 });
            dictionary.Add('i', new int[2] { 0, 0 });
            dictionary.Add('j', new int[4] { 1, 0, 0, 0 });
            dictionary.Add('k', new int[3] { 1, 0, 1 });
            dictionary.Add('l', new int[4] { 0, 1, 0, 0 });
            dictionary.Add('m', new int[2] { 1, 1 });
            dictionary.Add('n', new int[2] { 1, 0 });
            dictionary.Add('o', new int[3] { 1, 1, 1 });
            dictionary.Add('p', new int[4] {0, 1, 1, 0 });
            dictionary.Add('q', new int[4] { 1, 1, 0, 1 });
            dictionary.Add('r', new int[3] { 0, 1, 0 });
            dictionary.Add('s', new int[3] { 0, 0, 0 });
            dictionary.Add('t', new int[1] { 1 });
            dictionary.Add('u', new int[3] { 0, 0, 1 });
            dictionary.Add('v', new int[4] { 0, 0, 0, 1 });
            dictionary.Add('w', new int[3] { 0, 1, 1 });
            dictionary.Add('x', new int[4] { 1, 0, 0, 1 });
            dictionary.Add('y', new int[4] { 1, 0, 1, 1 });
            dictionary.Add('z', new int[4] { 1, 1, 0, 0 });
            dictionary.Add(' ', new int[1] {2});
            dictionary.Add('1', new int[5] { 0, 1, 1, 1, 1 });
            dictionary.Add('2', new int[5] { 0, 0, 1, 1, 1 });
            dictionary.Add('3', new int[5] { 0, 0, 0, 1, 1 });
            dictionary.Add('4', new int[5] { 0, 0, 0, 0, 1 });
            dictionary.Add('5', new int[5] { 0, 0, 0, 0, 0 });
            dictionary.Add('6', new int[5] { 1, 0, 0, 0, 0 });
            dictionary.Add('7', new int[5] { 1, 1, 0, 0, 0 });
            dictionary.Add('8', new int[5] { 1, 1, 1, 0, 0 });
            dictionary.Add('9', new int[5] { 1, 1, 1, 1, 0 });
            dictionary.Add('0', new int[5] { 1, 1, 1, 1, 1 });

            string word = Console.ReadLine();
            char letter;
            int count = 0;
            foreach (char c in word)
            {
                letter = word[count];
                int[] arr = dictionary[letter];
                foreach (int i in arr)
                {
                    if (i == 0)
                    {
                        Console.Beep(800, 200);
                    }
                    if (i == 1)
                    {
                        Console.Beep(800, 400);
                    }
                    if (i == 2)
                    {
                        Console.Beep(37, 800);
                    }
                }
                count++;

            }
            Console.ReadKey();
        }
    }
}
