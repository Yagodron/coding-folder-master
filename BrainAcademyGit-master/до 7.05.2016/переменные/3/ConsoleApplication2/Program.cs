using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            Console.WriteLine("x={0} y={1} z={2}" + '\n' + "x += y - x++ * z;", x, y, z);
            x += y - x++ * z;
            Console.WriteLine(x);
            Console.WriteLine("x={0} y={1} z={2}" + '\n' + "y /= x + 5 % z;", x, y, z);
            y /= x + 5 % z; 
            Console.WriteLine(x);
            Console.WriteLine("x={0} y={1} z={2}" + '\n' + "z = x++ + y * 5;", x, y, z);
            z = x++ + y * 5;
            Console.WriteLine(x);
            Console.WriteLine("x={0} y={1} z={2}" + '\n' + "x = y - x++ * z;", x, y, z);
            x = y - x++ * z;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
