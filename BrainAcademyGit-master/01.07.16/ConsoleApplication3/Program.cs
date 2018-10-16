using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Func<int, bool> test = i => i > 3;

            Expression<Func<int, bool>> exp = i => i > 3;
            Debug.WriteLineIf(test(5), "functions worcks correctly");
            Debug.Assert(test(2), "functions worcks incorrectly");

            BinaryExpression binary = (BinaryExpression)exp.Body;

            Console.ReadKey();
        }
    }
}
