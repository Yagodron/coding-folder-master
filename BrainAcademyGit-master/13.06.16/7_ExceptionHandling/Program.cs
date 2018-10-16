using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            try
            {
                int x = array[0];
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error NullReferenceException:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
            array = new int[10];
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    array[i] = i;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error IndexOutOfRangeException:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
            try
            {
                string index = null;
                Console.WriteLine(array[int.Parse(index)]);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Error ArgumentNullException:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            try
            {
                string index = "lol";
                Console.WriteLine(array[int.Parse(index)]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error FormatException:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }


            try
            {
                short[] array2 = new short[5];
                Console.WriteLine("input the index of the element you want to change");
                short x = short.Parse(Console.ReadLine());
                Console.WriteLine("input the value of the element you want to change");
                array2[x] = short.Parse(Console.ReadLine());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ///////////////////////
            try
            {

                try
                {
                    short[] array2 = new short[5];
                    Console.WriteLine("input the index of the element you want to make 10");
                    short x = short.Parse(Console.ReadLine());
                    array2[x] = 10;
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message, ex);
                }
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("lol");
                Console.WriteLine(exc.InnerException);
            }
            Console.ReadKey();
        }
    }
}
