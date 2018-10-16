using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadManipulator
{
    delegate void AddDelegate(int i);
    class Program
    {
        static void Main(string[] args)
        {

            var myThreadManipulatorInstance = new ThreadManipulator();

            ParameterizedThreadStart starter1 = new ParameterizedThreadStart(myThreadManipulatorInstance.AddOne);

            Thread addOneThread1 = new Thread(starter1);
            Thread addOneThread2 = new Thread(starter1);

            Thread addCustomThread = new Thread(myThreadManipulatorInstance.AddCustom);

            Thread stopThread = new Thread(myThreadManipulatorInstance.Stop);
            
            addOneThread1.Start(5);
            addOneThread2.Start(5);
            addCustomThread.Start(new int[] { 5, 4});
            stopThread.Start();
            
            addOneThread1.Join();
            addOneThread1.Join();
            addCustomThread.Join();
            stopThread.Join();
        }
    }

    class ThreadManipulator
    {
        public ConsoleKey _key;

        public void AddOne(object number)
        {
            for (int i = 1; i < 50; i++)
            {
                if (this._key == ConsoleKey.Q)
                {
                    break;
                }
                if (i % (int)number == 0)
                {
                    Console.WriteLine("Add One: {0}",i);
                }
                Thread.Sleep(100);
            }
        }

        public void AddCustom(object number)
        {
            int[] x = (int[])number;
            for (int i = x[1]; i < 200;i += x[1] )
            {
                if (this._key == ConsoleKey.W)
                {
                    break;
                }
                if (i % x[0] == 0)
                {
                    Console.WriteLine("Add Custom: {0}", i);
                }
                Thread.Sleep(100);
            }
        }

        public void Stop()
        {
            do
            {
                _key = Console.ReadKey().Key;
            } while (true);
 
        }
    }
}
