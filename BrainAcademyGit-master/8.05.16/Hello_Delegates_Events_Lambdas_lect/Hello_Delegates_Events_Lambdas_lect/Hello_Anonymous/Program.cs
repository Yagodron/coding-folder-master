using System;

namespace Hello_Anonymous
{
    delegate void factor(int j);
    delegate bool Lambda_ex(int v);
    delegate int Lambda_factor(int k);
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous method
            Console.WriteLine("Anonymous method");
            factor fact3 = delegate (int j)
            {
                for (int i = 1; i <= 3; ++i)
                {
                    j = j * i;
                    Console.WriteLine(j);
                }
                    
            }; //Pay attention to ;
            fact3(1);

            Console.WriteLine();
            //Lambda expression
            Lambda_ex ndiv2 = ll => ll % 3 == 0;
            Console.WriteLine("Lambda expression ");
            for (int i = 1; i <= 10; i++)
                if (ndiv2(i)) Console.WriteLine(i);

            Console.WriteLine();
            //Lambda statements
            Console.WriteLine("Lambda statements");
            Lambda_factor fact = n =>
            {
                int jj = 1;
                for (int i = 1; i <= n; i++)
                    jj = i * jj;
                return jj;
            };
            Console.WriteLine("The factorial of 1 is " + fact(1));
            Console.WriteLine("The factorial of 3 is " + fact(3));

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
