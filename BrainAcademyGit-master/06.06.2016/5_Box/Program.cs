using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recktangle
{
    class Program
    {
        public class Recktangle
        {
            private int _width;
            private int _height;
            private int x=0, y=0;
            private string message;
            public bool can_write = false;

            public Recktangle(int h, int w)
            {
                this._height = h;
                this._width = w;
            }
            public int Width()
            {
                return this._width;
            }
            public int Height()
            {
                return this._height;
            }
            public int available()
            {
                return (this._height * this._width) - ((this._height*2 + (this._width-2)*2));
            }
            public string Msg()
            {
                return this.message;
            }

            public void GetMessage(string msg)
            {
                this.message = msg;
            }

            public void Print_Box()
            {
                for (int i = 0; i<this._width; i++)
                    for (int j = 0; j < this._height; j++)
                    {
                        Console.SetCursorPosition(i, j);
                        if (i==0 || j == 0 || i==this._width-1 || j==this._height-1)
                        Console.Write("*");
                    }
            }

            public void Print_Message()
            {
                int curr_letter;
                int curr_level = 1;
                int delimiter = 0;
                for (int i = 1; i <= this.message.Length; i++)
                {
                    curr_letter = i - 1;
                    if (curr_letter == this._width - 2)
                    {
                        curr_level++;
                        delimiter = this._width - 2;
                    }
                    Console.SetCursorPosition(i-delimiter, curr_level);
                    Console.Write(this.message[curr_letter]);
                }         
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input height of the recktangle");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("input width of the recktangle");
            int w = int.Parse(Console.ReadLine());
            Recktangle Box = new Recktangle(h, w);
            Console.WriteLine("do you want to write smth? y/n");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("input the message");
                Box.GetMessage(Console.ReadLine());
                if (Box.Msg().Length <= Box.available())
                {
                    Box.can_write = true;
                }
                else 
                {
                    Console.WriteLine("can not write your message, not enough space");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            Box.Print_Box();
            if (Box.can_write)
            {
                Box.Print_Message();
            }
            Console.ReadKey();
        }
    }
}
