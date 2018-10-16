using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("input [{0},{1}] of your first array",i+1,j+1);
                    A[i,j]=int.Parse(Console.ReadLine());
                }
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("input [{0},{1}] of your second array", i+1, j+1);
                    B[i,j]=int.Parse(Console.ReadLine());
                }
            search(A, B);
            func(A, B);
            Console.ReadKey();
   
        }
        static void search(int[,] A, int[,] B)
        {
            Console.WriteLine("which array do you want to work with? 1 or 2");
            int caseSwitch1 = int.Parse(Console.ReadLine());
            bool A_any = false;
            bool B_any = false;
            switch (caseSwitch1)
            {
                case 1:
                    Console.WriteLine("input a number");
                    int your_number_A = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            if (your_number_A == A[i, j])
                            {
                                Console.WriteLine("index of your number in first array is: [{0},{1}]",i+1,j+1);
                                A_any = true;
                            }
                        }
                    if (A_any == false)
                    {
                        Console.WriteLine("none found");
                    }
                    break;
                case 2:
                    int your_number_B = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            if (your_number_B == B[i, j])
                            {
                                Console.WriteLine("index of your number in second array is: [{0},{1}]",i+1,j+1);
                                    B_any = true;
                            }
                        }
                    if (B_any == false)
                    {
                        Console.WriteLine("none found");
                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

        static void func(int[,] A, int[,] B)
        {
            int a = 0, b = 0;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    a += A[i, j];
                    b += B[i, j];
                }
            Console.WriteLine("sum of the first array is: {0}, of the second: {1}", a, b);
            if (a > b)
            {
                Console.WriteLine("first array's sum of elements is bigger");
            }
            if (a < b)
            {
                Console.WriteLine("second array's sum of elements is bigger");
            }
            if (a == b)
            {
                Console.WriteLine("sum of elements of both arrays are equal");
            }
        }
    }
}
