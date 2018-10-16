using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes {UAH, USD, EU};

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public int Amount;
        public CurrencyTypes CurrencyType;

        // 3) declare parameter constructor for properties initialization
        public Money(int a, CurrencyTypes type)
        {
            Amount = a;
            CurrencyType = type;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money money_one, Money money_two)
        {
            Money money_temp = new Money(0, money_one.CurrencyType);
            money_temp.Amount = money_one.Amount + money_two.Amount;
            return money_temp;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money money_one)
        {
            Money money_temp = new Money(0, money_one.CurrencyType);
            money_temp.Amount = money_one.Amount - 1;
            return money_temp;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money money_one, Money money_two)
        {
            Money money_temp = new Money(0, money_one.CurrencyType);
            money_temp.Amount = money_one.Amount * 3;
            return money_temp;
        }


        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money money_one, Money money_two)
        {
            bool result = (money_one.Amount - money_two.Amount) > 0 ? true : false;
            return result;
        }

        public static bool operator <(Money money_one, Money money_two)
        {
            bool result = (money_one.Amount - money_two.Amount) > 0 ? false : true;
            return result;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object

        public static bool operator true(Money money_one)
        {
            if (money_one.CurrencyType == CurrencyTypes.UAH)
                return true;
            else return false;
        }

        public static bool operator false(Money money_one)
        {
            if (money_one.CurrencyType != CurrencyTypes.UAH)
                return true;
            else return false;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static implicit operator double(Money money_one)
        {
            return money_one.Amount;
        }

        public static explicit operator double(Money money_one)
        {
            return (double)money_one.Amount;
        }

    }
}
