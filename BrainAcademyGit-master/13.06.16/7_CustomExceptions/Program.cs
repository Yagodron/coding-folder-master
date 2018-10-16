using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CustomExceptions
{
    public class ArrayElementIs13OhGodPleaseNo : Exception
    {
        public ArrayElementIs13OhGodPleaseNo()
        {
        }
        public ArrayElementIs13OhGodPleaseNo(string message)
            : base(message)
            {
            }
        public ArrayElementIs13OhGodPleaseNo(string message, Exception inner)
            : base(message, inner)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            try
            {
                array[0] = 13;
                if (array[0] == 13)
                {
                    throw new ArrayElementIs13OhGodPleaseNo("element is 13");
                }

            }
            catch (ArrayElementIs13OhGodPleaseNo ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
