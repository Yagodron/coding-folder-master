using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Helloo");

            Debug.Indent();
            Debug.WriteLine("Two");
            Debug.WriteLine("Three");
            Debug.Unindent();

            Debug.WriteLine("Four");
            Debug.Fail("Message");
            Debug.Assert(4 < 5); // assert = fail when false
        }
    }
}
