using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    // class declaration
    class MyClass
    {
        // method declaration
        public void MyMethod()
        {
            Console.WriteLine("My method calling");
        }

        public void MyMethod(int[] Arr)
        {
            Arr[0] = 100;  // it changes the original object
            Console.WriteLine("My method calling");
            Console.WriteLine("Arr[0] = {0}", Arr[0]);
        }

        public void MyMethod(ref int[] Arr)
        {
            // both changes will affect the orogonal values
            Arr[0] = 100;
            Arr = new int[6] { 100, 200, 300, 400, 500, 600 };
            Console.WriteLine("My method calling");
            Console.WriteLine("Arr[0] = {0}", Arr[0]);
        }

        public void MyMethod(ref int param1, out int param2)
        {
            // assigning of param1 isn't necessary and param2 is necessary
            //  param1 = 50;
            param2 = 100;

        }

        public void MyMethod2(params int[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine("Parameter {0} equals {1}", i, parameters[i]);
            }
        }

        public void MyMethod(int param1, string param2)
        {
            Console.WriteLine("param1: {0}, param2: {1}", param1, param2);
        }

        public void MyMethod3(int param1, string param2 = "some string")
     {
         Console.WriteLine("param1: {0}, param2: {1}", param1, param2);
     }

        public int Sum(int[] Arr, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
                sum += Arr[i];
            return sum;
        }

        // constructors
        public MyClass() { }
        public MyClass(int x) { }
        public MyClass(string s) { }

        public MyClass(int x, int y)
            : this(x * y)
        { }
        public MyClass(int x, string s) { }

        // properties
        public int prop1 { get; set; }
        public string prop2 { get; set; }
      
        // static
        public static int value;


    }
}
