using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input array size");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            double max = 0 , sum = 0, min = 101;
            double avg = 0;
            Random rnd = new Random();
            Console.WriteLine("your array:");
            for (int i = 0; i < size; i++)
            {
                A[i] = rnd.Next(0, 100);
                Console.Write(A[i] + " ");
                if (A[i] > max) { max = A[i]; }
                if (A[i] < min) { min = A[i]; }
                sum+=A[i];
            }
            avg = sum / size;
            Console.WriteLine("\nmax:{0} \nmin:{1} \ntotal:{2} \naverage:{3} \nodd values:",max, min, sum, avg);
            for (int i = 0; i < size; i++)
            {
                if (A[i]%2==1)
                {
                    Console.Write(A[i] + " ");
                }
            }
            Console.ReadKey();
            
        }
    }
}
