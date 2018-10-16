using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int a = int.Parse(Console.ReadLine());
            if (a>=0 && a<=14)
            {
                Console.WriteLine("a belongs to [0;14]");
            }
            else if (a >= 15 && a <= 35)
            {
                Console.WriteLine("a belongs to [15;35]");
            }
            else if (a >= 36 && a < 50)
            {
                Console.WriteLine("a belongs to [36;50]");
            }
            else if (a > 50 && a <= 100)
            {
                Console.WriteLine("a belongs to [50;100]");
            }
            else if (a == 50)
            {
                Console.WriteLine("a belongs to both [36;50] and [50;100]");
            }
            Console.ReadKey();
        }
    }
}
