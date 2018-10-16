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
            Console.WriteLine("input a");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("input b");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("input c");
            double c = int.Parse(Console.ReadLine());
            double d = (a + b + c) / 3;
            Console.WriteLine("result:" +'\n' + "(" + a + "+" + b + "+" + c + ")" + "/3=" + d);
            Console.ReadKey();
        }
    }
}
