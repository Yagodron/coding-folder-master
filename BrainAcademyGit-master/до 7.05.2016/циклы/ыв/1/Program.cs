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
            int a, b = 0;
            string choose=Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.Write("input a and b");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        if (i == 0) { Console.Write("*"); }
                        Console.Write("*");
                        if (i == (a-1)) { Console.Write("*"); }
                    }
                    for (int i = 0; i < b; i++)
                    {
                        Console.Write("\n");
                    }
                    for (int i = 0; i < a; i++)
                    {
                        if (i == 0) { Console.Write("*"); }
                        Console.Write(" ");
                        if (i == (a - 1)) { Console.Write("*"); }
                    }
                    break;
                case "2":
                    Console.Write("input a and b");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.Write("*");
                    for (int i = 0; i < b; i++)
                    {
                        Console.Write("\n");
                    }
                    for (int i = 0; i < a; i++)
                    {
                        if (i == 0) { Console.Write("*"); }
                        Console.Write(" ");
                        if (i == (a - 1)) { Console.Write("*"); }
                    }
                    break;
                case "3":
                    Console.Write("input a and b");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a*2; i=+2)
                    {
                        if (i == a) { Console.Write("*"); }
                        Console.Write(" ");
                        //if (i == (a - 1)) { Console.Write("*"); }
                    }
                    for (int i = 0; i < b * 2; i = +2)
                    {
                        if (i == b) { Console.Write("*"); }
                        Console.Write("\n");
                        //if (i == (a - 1)) { Console.Write("*"); }
                    }
                    for (int i = 0; i < a * 2; i = +2)
                    {
                        if (i == a) { Console.Write("*"); }
                        Console.Write(" ");
                        //if (i == (a - 1)) { Console.Write("*"); }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
