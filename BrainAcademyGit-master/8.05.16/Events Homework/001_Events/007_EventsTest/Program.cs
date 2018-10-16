using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    delegate void MyDel();

    class MyClass
    {
        static void Handler()
        {
            Console.WriteLine("Some string");
        }

        public event MyDel someEvent = null;

        public MyClass()
        {
            someEvent += Handler;
        }

        public void Invoke()
        {
            someEvent.Invoke();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass inst = new MyClass();


            inst.Invoke();


        }
    }
}
