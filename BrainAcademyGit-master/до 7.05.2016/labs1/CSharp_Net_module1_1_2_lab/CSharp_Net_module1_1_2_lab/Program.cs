namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)
            bool boo = true;
            char ch = 'c';
            byte b = 250;
            sbyte sb = 120;
            short sh = 10000;
            ushort ush = 25;
            int i = -223;
            uint ui = 300;
            long l = 500;
            ulong ul = 400;
            decimal de = 100000.6M;
            float fl = 255.5F;
            double d0 = 234.5;

         

            //2) declare constants of int and double. Try to change their values.

            const int ci = 12;
            const double cd0 = 12.5;
           

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            var one = 20;
            var two = 20.5;
            //one = 20.5;
            //two = 20;
           

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            System.Int32 varone = i;
            System.Double vartwo = d0;

           

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
               // int i = 12;
                //char ch = 'a';
                //double d0 = 1234.7;

                // 6) change values of variables from 1)
                i = 12;
                ch = 'a';
                d0 = 1234.7;

            }

            // 7)check values of variables from 1). Are they changed? Think, why
 

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char
            i = ch;
            // bool -> short
            //boo = sh;
            // double -> long
            d0 = l;
            // float -> char 
            fl = ch;
            // int to char
            i = ch;
            // decimal -> double
            de = (decimal)d0;
            // byte -> uint
            b = (byte)ui;
            // ulong -> sbyte
            ul = (ulong)sb;
            // 9) and reverse conversion with fixing compilation errors.
            ch = (char)i;
            // bool -> short
            //sh = boo;
            // double -> long
            l = (long)d0;
            // float -> char 
            ch = (char)fl;
            // int to char
            ch = (char)i;
            // decimal -> double
            d0 = (double)de;
            // byte -> uint
            ui = b;
            // ulong -> sbyte
            sb = (sbyte)ul;

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            //int nullabe = null;
 
        }
    }
}
