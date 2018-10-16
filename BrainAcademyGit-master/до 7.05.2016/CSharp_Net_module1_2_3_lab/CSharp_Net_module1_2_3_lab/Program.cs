using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money UAH = new Money(15, CurrencyTypes.UAH);
            Money USD = new Money(1, CurrencyTypes.USD);
            Money UAH1 = new Money(10, CurrencyTypes.UAH);
            UAH--;
            UAH1=UAH+USD;
            Console.WriteLine(UAH.Amount);
            if (UAH > UAH1) { Console.WriteLine("success"); }
            Console.ReadKey();

            // 11) do operations
            // add 2 objects of Money
            
            // add 1st object of Money and double

            // decrease 2nd object of Money by 1 

            // increase 1st object of Money

            // compare 2 objects of Money

            // compare 2nd object of Money and string

            // check CurrencyType of every object

            // convert 1st object of Money to string

        }
    }
}
