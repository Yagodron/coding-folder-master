using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arr_length;
            Console.WriteLine("input length");
            arr_length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arr_length];
            for (int i = 0; i < arr_length; i++)
            {
                arr1[i] = rnd.Next(100);
            }
            Console.WriteLine("before: ");
            for (int i = 0; i < arr_length; i++)
            {
                Console.Write("{0}, ", arr1[i]);
            }
            arr1 = Reverse(arr_length, arr1);
            Console.WriteLine("\nafter: ");
            for (int i = 0; i < arr_length; i++)
            {
                Console.Write("{0}, ", arr1[i]);
            }
            Console.WriteLine();
            int[] arr100 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr100[i] = i + 1;
                if (i % 2 == 1)
                {
                    Console.Write("{0}, ", arr100[i]);
                }
            }
            Console.ReadLine();
        }

        static int[] Reverse(int arr1_length, int[] arr1)
        {
            int[] arr = new int[arr1_length];
            for (int i = 0; i < arr1_length; i++)
            {
                arr[arr1_length - i - 1] = arr1[i];
            }
            return arr;
        }
    }
}
