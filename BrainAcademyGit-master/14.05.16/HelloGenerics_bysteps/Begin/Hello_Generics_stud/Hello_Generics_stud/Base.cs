using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Generics_stud
{
    public class Base<T> where T : new()
    {
        static Base()
        {
            Console.WriteLine("base text");
            T intern = new T();
        }
    }

    public sealed class Derived : Base<Derived>
    {
        public Derived()
        {
            Console.WriteLine("derived text");
        }
    }

    public class Base_public_field<T> where T : new()
    {
        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }
        static Base_public_field()
        {
            Console.WriteLine("Base_public_field text");
            T intern = new T();
        }
    }

    public sealed class Derived_public_field : Base_public_field<Derived_public_field>
    {
        public Derived_public_field()
        {
            Console.WriteLine("Derived_public_field text");
        }
    }

    public class Base_static_field<T> where T : new()
    {
        static T _instance;
        static T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }
        protected Base_static_field()
        {
            Console.WriteLine("Base_static_field text");
        }
    }

    public sealed class Derived_static_field : Base_static_field<Derived_static_field>
    {
        public Derived_static_field()
        {
            Console.WriteLine("Derived_static_field text"); 
        }
    }

    public class Base_publ<T> where T : new()
    {
        static Base_publ()
        {
            Console.WriteLine("Base_publ text");
            T intern = new T();
        }
    }

    public sealed class Derived_publ : Base_publ<Derived_publ>
    {
        public Derived_publ()
        {
            Console.WriteLine("Derived_publ text"); 
        } 
    }

    public static class Curry_list
    {
        public static Func<TArg2, Func<TArgl, TResult>> Bnd<TArgl, TArg2, TResult>(this Func<TArgl, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }

    }
}
