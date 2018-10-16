using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEnumerator
{
        class MyClass : IEnumerable
    {
        public string[] _class = { "warrior", "paladin" , "death knight", "hunter", "shaman", "rouge", "druid", "monk", "warlock", "mage", "priest"};

        public IEnumerator GetEnumerator()
        {
            foreach (string value in _class)
                yield return value;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            foreach (var value in obj._class)
            {
                Console.WriteLine("try {0}", value);
            }
            Console.ReadKey();
        }
    }


}
