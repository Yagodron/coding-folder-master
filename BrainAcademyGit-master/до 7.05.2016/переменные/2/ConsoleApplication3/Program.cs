using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("input r");
            string s = Console.ReadLine();
            double a = Math.Pow(int.Parse(s),2) * pi;
            Console.WriteLine("Pi*R^2=" + a);
            Console.ReadKey();
        }
    }
}
