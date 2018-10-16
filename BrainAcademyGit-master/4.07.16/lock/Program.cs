using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace @lock
{
    class Program
    {
        public static int Total;

        static void Main(string[] args)
        {
            //ThreadStart starter = new ThreadStart(Increment);
            Thread thread1 = new Thread(Increment);
            Thread thread2 = new Thread(Increment);
            Thread thread3 = new Thread(Increment);
            
            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.ReadKey();
        }
        static object _lock = new object();
        static void Increment()
        {
            lock (_lock)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Total++;
                }
            }
            //for (int i = 0; i < 1000000; i++)
            //{
            //    //Interlocked.Increment(ref Total);
            //    //Total++;
            //}

            
        }
    }
}
