using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0,100), b = rnd.Next(0,100);
            double z = 0;
            Console.WriteLine("a={0} b={1}", a, b);
            Console.WriteLine("input a sign(+;-;*;/)");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    z = a + b;
                    Console.WriteLine("z={0}", z);
                    break;
                case "-":
                    z = a - b;
                    Console.WriteLine("z={0}", z);
                    break;
                case "*":
                    z = a * b;
                    Console.WriteLine("z={0}", z);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("b = 0, can't divide by 0");
                        break;
                    }
                    z = a / b;
                    Console.WriteLine("z={0}",z);
                    break;
                default:
                    Console.WriteLine("wrong sign");
                    break;
            }

            Console.ReadKey();
        }
    }
}
