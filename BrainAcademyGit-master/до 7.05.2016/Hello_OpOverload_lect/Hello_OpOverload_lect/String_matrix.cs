using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_OpOverload_lect
{
    class String_matrix
    {
        string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
{ ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", ".----", "..---", "...--", "....-" }};
        Random rnd = new Random();
        public const int Size1 = 2, Size2 = 36;
        private string[,] str_matrix = new string[Size1, Size2];

        public String_matrix()
        { 
        }

        public String_matrix(bool Rnd)
        {
            if (Rnd)
            {
            // Random  signal
                for (int i = 0; i < Size1; i++)
                    for (int j = 0; j < Size2; j++)
                        this[i, j] = Dictionary_arr[i,rnd.Next(0, 35)];
            //
            }
            else 
            {
            // Standard sequence
                for (int ii = 0; ii < Size1; ii++)
                    for (int jj = 0; jj < Size2; jj++)
                        this[ii, jj] = Dictionary_arr[ii, jj];
            }
        }

        // indexer
        public string this[int x, int y]
        {
            get { return str_matrix[x, y]; }
            set { str_matrix[x, y] = value; }
        }


        public  void Write_matrix()
        {
            Console.WriteLine();
            for (int i = 0; i < Size2; i++)
            {
                Console.Write(" ");
                
                for (int j = 0; j < Size1; j++)
                {
                    // 
                    Console.Write(" " + this[j, i] );
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        // + operator 
        public static String_matrix operator +(String_matrix tbl1, String_matrix tbl2)
        {
            String_matrix res_str_matrix = new String_matrix();

            for (int i = 0; i < Size1; i++)
                for (int j = 0; j < Size2; j++)
                    res_str_matrix[i, j] = tbl1[i, j] + tbl2[i, j];

            return res_str_matrix;
        }

        public static String_matrix operator +(String_matrix tbl1, String_column tbl2)
        {
            String_matrix res_str_matrix = new String_matrix();

            for (int i = 0; i < Size1; i++)
                for (int j = 0; j < Size2; j++)
                    res_str_matrix[i, j] = tbl1[i, j] + " " + tbl2[j];

            return res_str_matrix;
        }

        public static String_matrix operator ++(String_matrix tbl1)
        {
            String_matrix res_str_matrix = new String_matrix();

            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size2-1; j++)
                    res_str_matrix[i, j] = tbl1[i, j] + " " + tbl1[i, j + 1];
                res_str_matrix[i, Size2 - 1] = tbl1[i, Size2 - 1] + " " + tbl1[i, 0];
            }
            return res_str_matrix;
        }

        public  string Str_clmn()
        {
            string clmn = null;
            for (int j = 0; j < Size2; j++)
            {
                clmn += this[0, j];               
            }
            return clmn;
        }

        public static bool operator >=(String_matrix tbl1, String_matrix tbl2)
        {
            bool res_str_matrix = String.Compare(tbl1.Str_clmn(), tbl2.Str_clmn()) >= 0 ? true : false;
            return res_str_matrix;
        }

        public static bool operator <=(String_matrix tbl1, String_matrix tbl2)
        {
            bool res_str_matrix = String.Compare(tbl1.Str_clmn(), tbl2.Str_clmn()) <= 0 ? true : false;
            return res_str_matrix;
        }

        public static bool operator >(String_matrix tbl1, String_matrix tbl2)
        {
            bool res_str_matrix = String.Compare(tbl1.Str_clmn(), tbl2.Str_clmn()) > 0 ? true : false;
            return res_str_matrix;
        }

        public static bool operator <(String_matrix tbl1, String_matrix tbl2)
        {
            bool res_str_matrix = String.Compare(tbl1.Str_clmn(), tbl2.Str_clmn()) < 0 ? true : false;
            return res_str_matrix;
        }

        public override bool Equals(object obj)
        {
            String_matrix strob = (String_matrix)obj;
            return String.Compare(strob.Str_clmn(), this.Str_clmn()) == 0 ? true : false;;
        }

        public override int GetHashCode()
        {
           return this.Str_clmn().GetHashCode();
        }
    }
}
