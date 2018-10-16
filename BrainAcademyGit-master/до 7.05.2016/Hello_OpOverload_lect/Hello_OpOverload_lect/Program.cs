using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_OpOverload_lect
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            try
            {
                do
                {
                    //do something
                    Console.WriteLine(@"Please,  type the number:
                        1.  String matrix plus
                        2.  String matrix plus column
                        3.  String matrix ++
                        4.  Built-in operator overloading
                        5.  Relational operators
                        6.  True/false and logical operators overloading
                        7.  Implicit/explicit keywords
                        ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Str_matr();
                                Console.WriteLine("");
                                break;
                            case 2:
                                Str_column_matr();
                                Console.WriteLine("");
                                break;
                            case 3:
                                Str_plusplus_matr();
                                Console.WriteLine("");
                                break;
                            case 4:
                                built_in_str();
                                Console.WriteLine("");
                                break;
                            case 5:
                                Str_bool_matr();
                                Console.WriteLine("");
                                break;
                            case 6:
                                Arrow_opovel();
                                Console.WriteLine("");
                                break;
                            case 7:
                                Arrow_impl_expl();
                                Console.WriteLine("");
                                break;
                           
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {
                        //Console.WriteLine("Press any key");
                        //Console.ReadLine();
                    }

                    //end do something
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #region Str_matrix
        static void Str_matr()
        {
            String_matrix tbl1 = new String_matrix(false);
            String_matrix tbl2 = new String_matrix(true);


            // print out tables
            Console.WriteLine("Code 1: ");
            tbl1.Write_matrix();

            Console.WriteLine("Code 2: ");
            tbl2.Write_matrix();

            // perform addition and print out  results
            String_matrix tbl3 = tbl1 + tbl2;

            Console.WriteLine();
            Console.WriteLine("Code 1 + Code 2 = ");
            tbl3.Write_matrix();

            tbl3 += tbl2;

            Console.WriteLine();
            Console.WriteLine("Code 1 + Code2 + Code 2 = ");
            tbl3.Write_matrix();
        }
        #endregion

        #region Str_column_matr
        static void Str_column_matr()
        {
            String_matrix tbl1 = new String_matrix(false);
            String_column tbl2 = new String_column();

            // print out tables
            Console.WriteLine("Code 1: ");
            tbl1.Write_matrix();

            Console.WriteLine("Using  column. ");

            // perform addition and print out  results
            String_matrix tbl3 = tbl1 + tbl2;

            Console.WriteLine();
            Console.WriteLine("Code 1 + column = ");
            tbl3.Write_matrix();
        }
        #endregion

        #region Str_plusplus_matr
        static void Str_plusplus_matr()
        {
            String_matrix tbl1 = new String_matrix(false);
            //String_matrix tbl3 = new String_matrix(false);

            // print out tables
            Console.WriteLine("Code 1: ");
            tbl1.Write_matrix();

            // perform increment and print out  results
            tbl1 = ++tbl1;

            Console.WriteLine();
            Console.WriteLine("Code 1 ++ = ");
            tbl1.Write_matrix();
        }
        #endregion

        #region built_in_str

        static void built_in_str()
        {
            String_column clmn1 = new String_column();
            int Size = 36;
            for (int i = 0; i < Size; i++)
            {
                clmn1[i] = clmn1[i] + " " + i;
            }
            string s = clmn1 + " String column : ";
            Console.WriteLine(s);
        }
        #endregion

        #region Str_bool_matr()
        static void Str_bool_matr()
        {

            String_matrix tbl1 = new String_matrix(false);
            String_matrix tbl2 = new String_matrix(true);

		
		    // print out tables
		    Console.WriteLine("Code 1: ");
		    tbl1.Write_matrix();

		    Console.WriteLine("Code 2: ");
		    tbl2.Write_matrix();

		    bool comp = tbl1 >= tbl2;
		    Console.WriteLine();
		    Console.WriteLine("Compare >= "+ comp);

            comp = tbl1 <= tbl2;
            Console.WriteLine();
            Console.WriteLine("Compare <= " + comp);

            comp = tbl1 < tbl2;
            Console.WriteLine();
            Console.WriteLine("Compare < " + comp);

            comp = tbl1 > tbl2;
            Console.WriteLine();
            Console.WriteLine("Compare > " + comp);
        }
        #endregion

        #region Arrow
        static void Arrow_opovel()
        {
            Arrow chance = new Arrow(0, 0);
            if (chance)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine();
            Console.WriteLine("Logical operators overloading");
            Arrow arr1 = new Arrow(0, 0);
            Arrow arr2 = new Arrow(12, 0);

            Console.WriteLine(arr1 & arr1);                 // False
            Console.WriteLine(arr1 & arr2);                 // False
            Console.WriteLine(arr2 & arr1);                 // False
            Console.WriteLine(arr2 & arr2);                 // True

        }
        #endregion

        #region Arrow_cast
        static void Arrow_impl_expl()
        {
            Console.WriteLine("Implicit keyword using");
            Arrow arr = new Arrow(10, 10);
            double d = arr;
            Console.WriteLine("Arrow size = "+d);

            Console.WriteLine("Explicit keyword using");
            float fl_arr = (float)arr;
            Console.WriteLine(fl_arr);
            Console.WriteLine("Arrow size = " + fl_arr);  
        }
        #endregion
    }
}
