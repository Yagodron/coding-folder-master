using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();

            Task task1 = new Task(() => Factorial(5, source.Token));
            Task.Factory.StartNew(() => Factorial(2, source.Token)).ContinueWith((nextTask) => Factorial_2(7, source.Token));
            //Task async_task = Factorial_async(6, source.Token);
           // int result = await task1.Start();

            Task<int>.Factory.StartNew(() => Factorial_r(3, source.Token)).ContinueWith((result_callback) => Console.WriteLine("result form callback {0}",result_callback.Result));

            task1.Start();

            Task<int> task2 = Task<int>.Factory.StartNew(() => Factorial_r(3, source.Token));
            int i = task2.Result;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                source.Cancel();
            }

            Console.ReadKey();
        }

        static void Factorial(int num, CancellationToken token)
        {
            Console.WriteLine("start of threadID: {0}", Thread.CurrentThread.ManagedThreadId);
            int result = 1;
            do
            {
                result *= num;
                Thread.Sleep(200);
                //Console.WriteLine("current result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
                num--;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelation requested");
                    token.ThrowIfCancellationRequested();
                }
            } while (num != 1);
            Console.WriteLine("end result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
            //return result;
        }

        static int Factorial_r(int num, CancellationToken token)
        {
            Console.WriteLine("Task.Result : start of threadID: {0}", Thread.CurrentThread.ManagedThreadId);
            int result = 1;
            do
            {
                result *= num;
                Thread.Sleep(200);
                //Console.WriteLine("current result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
                num--;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelation requested");
                    token.ThrowIfCancellationRequested();
                }
            } while (num != 1);
            Console.WriteLine("Task.Result : end result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
            return result;
        }

        static void Factorial_2(int num, CancellationToken token)
        {
            Console.WriteLine("task 2, start of threadID: {0}", Thread.CurrentThread.ManagedThreadId);

            int result = 1;
            do
            {
                result *= num;
                Thread.Sleep(200);
               // Console.WriteLine("task 2, current result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
                num--;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelation requested");
                    token.ThrowIfCancellationRequested();
                }
            } while (num != 1);
            Console.WriteLine("task 2, end result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
            //return result;
        }


        static async int Factorial_async(int num, CancellationToken token)
        {
            //await Task.Delay(2000);
            var source = new CancellationTokenSource();

           // Task<int> task1 = new Task<int>(() => Factorial_r(5, source.Token));
            int result = await Task<int>.Factory.StartNew(() => Factorial_r(5, source.Token));
            Console.WriteLine("async/await start of threadID: {0}", Thread.CurrentThread.ManagedThreadId);
           // int result = 1;
            do
            {
                result *= num;
                
                num--;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelation requested");
                    token.ThrowIfCancellationRequested();
                }
            } while (num != 1);
            Console.WriteLine("async/await end result = {0} threadID: {1}", result, Thread.CurrentThread.ManagedThreadId);
            
             return result;
        }
    }
}
