using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesToBeTested
{
    public class Customer
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public bool HasCard { get; set; }

        public Customer()
        {
            this.Name = "unnknown";
            this.Amount = 0.0;
            this.HasCard = false;
        }

        public Customer(string name, double amount, bool hasCard)
        {
            this.Name = name;
            this.Amount = amount;
            this.HasCard = hasCard;
        }

        public bool IsEnough(double sum)
        {
            return this.Amount > sum;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
