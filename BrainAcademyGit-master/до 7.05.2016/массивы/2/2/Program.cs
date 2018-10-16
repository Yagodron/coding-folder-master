using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static int[] SubArray(int[] array, int index, int count)
        {
            int z=0;
            int a = array.Length;
            int[] B = new int[count];
            do
            {
                if ((z+index-1)>=a)  {B[z]=1;}
                else B[z] = array[z+index-1];
                z++;
            }
            while (z<count);

            return B;
        }
        static int[] MyReverse(int [] A)
        {
            Array.Reverse(A);
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input array size");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            Random rnd = new Random();
            Console.Write("your array: ");
            for (int i = 0; i < size; i++)
            {
                A[i] = rnd.Next(0, 100);
                Console.Write(A[i] + " ");
            }
            Console.Write("\n");
            MyReverse(A);
            Console.Write("reverse array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(A[i] + " ");
            }
            MyReverse(A);
            Console.WriteLine("\ninput index and counter for array partitioning");
            int index = int.Parse(Console.ReadLine());
           // index--;
            int count = int.Parse(Console.ReadLine());
            int[] B = new int[count];
            B=SubArray(A,index,count);
            Console.Write("part of your array: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
