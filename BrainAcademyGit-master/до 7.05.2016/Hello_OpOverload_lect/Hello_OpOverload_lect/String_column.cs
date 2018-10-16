using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_OpOverload_lect
{
    class String_column
    {
        public const int Size2 = 36;
        public int Max_Length = Size2;
        private string[] str_column = new string[Size2];

        public String_column()
        {
            for (int i = 0; i < Size2; i++)
            {
                this[i] = null;
            }
        }

        public string this[int x]
        {
            get { return str_column[x]; }
            set { str_column[x] = value; }
        }

        public static string operator +(String_column obj1, string s)
        {
            string s1 = s;
            for (int i = 0; i < obj1.Max_Length; i++)
            {
                s1 = s1 + obj1[i];
            }
            s = s1;
            return s;
        }

    }
}
