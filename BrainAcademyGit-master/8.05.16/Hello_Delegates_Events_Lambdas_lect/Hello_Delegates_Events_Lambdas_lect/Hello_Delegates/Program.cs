using System;

namespace Hello_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            UnOp myup = new UnOp();
            UnOpHandler myvar3;
            Console.WriteLine("Creating delegates");
            UnOpHandler myvar2 = new UnOpHandler(myup.Incr);
            int j = myvar2(2);
            Console.WriteLine(j);

            UnOpHandler myvar1 = myup.Mines;
            int k = myvar1(2);
            Console.WriteLine(k);

            Console.WriteLine("Multicasting");
            myvar3 = myvar1;
            int m = myvar1(1);
            Console.WriteLine("Addition next method");
            Console.WriteLine(m);
            myvar3 += myvar2;
            m = myvar3(1);
            Console.WriteLine(m);
            Console.WriteLine("Removing last method");
            myvar3 -= myvar2;
            m = myvar3(1);
            Console.WriteLine(m);
            Console.ReadLine();
        }

    }

    public delegate int UnOpHandler(int i);
    class UnOp
    {
        public int Incr(int i)
        { return ++i; }

        public int Mines(int i)
        { return -i; }
    }
}
