using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            bool used = false;
            for (int i = 0; i < 100; i++)
            {
                used = false;
                arr[i] = i+1;
                if (arr[i] % 3 == 0)
                {
                    Console.Write("{0} - Fizz", arr[i]);
                    used = true;
                }
                if (arr[i] % 5 == 0)
                {
                    if (used)
                    {
                        Console.Write("Buzz");
                    }
                    else
                    {
                        Console.Write("{0} - Buzz", arr[i]);
                    }
                    used = true;
                }
                if (used)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
