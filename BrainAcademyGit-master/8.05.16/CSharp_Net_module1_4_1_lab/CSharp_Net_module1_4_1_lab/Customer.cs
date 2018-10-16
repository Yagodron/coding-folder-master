using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Customer
    {
        // 6) declare private field name
        private string name;

        public Customer(string name_)
        {
            name = name_;
        }

        // 7) declare constructor to initialize name
      

        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type
        public void GotNewGoods (object sender,GoodsInfoEventArgs e)
        {
            Console.WriteLine("pisechka");
        }
    }
}
