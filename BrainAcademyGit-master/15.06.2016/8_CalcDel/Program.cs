using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CalcDel
{

    public delegate float MyDelegate(float x);
   
    class Calculate
    {
        public float _x;
       // public event MyDelegate event1;
        public Calculate(float x)
        {
            this._x = x;
        }

        public float Go(float x)
        {
            Console.Write(this._x);
            return this._x;
        }

        public float Plus(float y)
        {
            Console.Write(" + " + y + " = ");
            this._x += y;
            Console.Write(this._x);
            return this._x;
        }

        public float Minus(float y)
        {
            Console.Write(" - " + y + " = ");
            this._x -= y;
            Console.Write(this._x);
            return this._x;
        }

        public float Multiply(float y)
        {
            Console.Write(" * " + y + " = ");
            this._x = this._x * y;
            Console.Write(this._x);
            return this._x;
        }
        public float Divide(float y)
        {
            Console.Write(" / " + y + " = ");
            this._x = this._x / y;
            Console.Write(this._x);
            return this._x;
        }
        public float View(float y)
        {
            Console.WriteLine("\nresult is : " + this._x);
            return this._x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            Calculate calc = new Calculate(float.Parse(Console.ReadLine()));
            Console.WriteLine("input second number");
            var y = (float.Parse(Console.ReadLine()));
            MyDelegate delegate_plus = new MyDelegate(calc.Plus);
            MyDelegate delegate_minus = new MyDelegate(calc.Minus);
            MyDelegate delegate_multiply = new MyDelegate(calc.Multiply);
            MyDelegate delegate_divide = new MyDelegate(calc.Divide);
            MyDelegate delegate_result = new MyDelegate(calc.Go);

            
            do
            {
                Console.WriteLine("1) plus\n2) minus\n3) multiply \n4) divide \n5) calculate");
                int case_switcher = int.Parse(Console.ReadLine());
                switch (case_switcher)
                {
                    
                    case 1:
                        {
                            delegate_result += delegate_plus;
                            break;
                        }
                    case 2:
                        {
                            delegate_result += delegate_minus;
                            break;
                        }
                    case 3:
                        {
                            delegate_result += delegate_multiply;
                            break;
                        }
                    case 4:
                        {
                            delegate_result += delegate_divide;
                            break;
                        }
                    case 5:
                        {
                            delegate_result += calc.View;
                            delegate_result(y);
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (true);
        }
    }
}