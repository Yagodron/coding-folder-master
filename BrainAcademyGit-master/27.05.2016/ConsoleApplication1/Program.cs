using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("input x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("input y:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("result: " + (x + y));
            Console.ReadKey();
        }
    }
}
