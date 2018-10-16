using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace APM_factorial
{
    public delegate int MyHandler(int k);


    class Program
    {
        static MyHandler handler;
        
        static void Main(string[] args)
        {
            BeginCountFactorial();
            
            Console.ReadLine();
        }

        static void BeginCountFactorial()
        {
            handler = new MyHandler(CountFactorial);
            IAsyncResult resultObj = handler.BeginInvoke(10, new AsyncCallback(EndCountFactorial), "object for locking");
        }

        static int CountFactorial(int x)
        {
            int y = 1;
            do
            {
                y *= x;
                x--;
            } while (x != 1);
            return y;
        }


        static void EndCountFactorial(IAsyncResult resultobject)
        {
            int res = handler.EndInvoke(resultobject);
            Console.WriteLine("Результат: {0}", res);
        }
    }
}
