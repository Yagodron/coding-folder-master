using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public bool asdasd(int i)
        {
            return i > 3; // same as Func
        }

        static void Main(string[] args)
        {
            //Func<int, bool> test = i => i > 3;
            //Console.WriteLine(test(5));
            //Console.WriteLine(test(2));
            Expression<Func<int, bool>> test = i => i > 3;
            Console.WriteLine(test.Body);

            BinaryExpression binary = (BinaryExpression)test.Body;
            Console.WriteLine(binary.Left);
            Console.WriteLine(binary.NodeType);
            Console.WriteLine(binary.Right);

            Console.ReadKey();
        }
    }
}
