using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            Console.WriteLine("input a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("factorial of the number:{0}",fact(n));
            Console.ReadKey();
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
        static int fact(int n)
        {
            return (n == 0) ? 1 : n * fact(n - 1);
        }

    }

    

}
