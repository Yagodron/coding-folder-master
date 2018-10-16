using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overload
{

    public class Number
    {
        public int value;
        public Number(int n)
        {
            this.value = n;
        }
        public static Number operator +(Number x, Number y)
        {
            Number z = new Number(0);
            z.value = x.value + 2 * y.value;
            return z;
        }
    }
    class Program
    {



        static void Main(string[] args)
        {
            Number x = new Number(5);
            Number y = new Number(10);
            Number z = new Number(0);
            z = x + y;
            Console.WriteLine("\"+\" now adds second part two times, so {0}+{1}={2}",x.value,y.value,z.value);
            Console.ReadKey();
        }
    }
}
