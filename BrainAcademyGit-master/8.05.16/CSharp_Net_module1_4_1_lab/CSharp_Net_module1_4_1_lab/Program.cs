using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            var our_shop = new OnlineShop();
            // 10) declare several objects of Customer
            var customer1 = new Customer("petr");
            var customer2 = new Customer("vasil");
            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
            our_shop.event4 += customer1.GotNewGoods;
            our_shop.event4 += customer2.GotNewGoods;
            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            our_shop.NewGoods("milk");
            Console.ReadKey();
        }
    }
}
