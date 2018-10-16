using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello_Class_lect;

namespace Hello_Class_lect
{
   public class Stud_message: IMessages
    {      
            private string mes_Code;
            private string date;
            private double mess_count;
            public Stud_message()
            {
                mes_Code = " ";
                date = " ";
                mess_count = 0.0;
            }

            public Stud_message(string cod, string s, double n)
            {
                mes_Code = cod;
                date = s;
                mess_count = n;
            }

            public double get_count()
            {
                return mess_count;
            }

            public void show_message()
            {
                Console.WriteLine("Message: {0}", mes_Code);
                Console.WriteLine("Date: {0}", date);
                Console.WriteLine("Count: {0}", get_count());
            }
        

    }
}
