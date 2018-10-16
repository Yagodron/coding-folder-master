using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_OpOverload_lect
{
    class Arrow
    {
        private int arr_x, arr_y;

        public Arrow(int x, int y) { arr_x = x; arr_y = y; }

        public int X
        {
            get { return arr_x; }
            set { arr_x = value; }
        }

        public int Y
        {
            get { return arr_y; }
            set { arr_y = value; }
        }

        public static Arrow operator +(Arrow arr1, Arrow arr2)
        {
            return new Arrow(arr1.X + arr2.X, arr1.Y + arr2.Y);
        }

        public static Arrow operator -(Arrow arr1, Arrow arr2)
        {
            return new Arrow(arr1.X - arr2.X, arr1.Y - arr2.Y);
        }

        public static Arrow operator *(Arrow arr1, int scale)
        {
            return new Arrow(arr1.X * scale, arr1.Y * scale);
        }

        public static Arrow operator *(int scale, Arrow arr1)
        {
            return new Arrow(arr1.X * scale, arr1.Y * scale);
        }

        public static Arrow operator ++(Arrow v)
        {
            v.X++;
            v.Y++;
            return v;
        }

        public static Arrow operator --(Arrow v)
        {
            v.X--;
            v.Y--;
            return v;
        }

        public static Arrow operator -(Arrow v)
        {
            return new Arrow(-v.X, -v.Y);
        }

        public static bool operator true(Arrow v)
        {
            if ((v.X != 0) || (v.Y != 0))
                return true;
            else
                return false;
        }

        public static bool operator false(Arrow v)
        {
            if ((v.X == 0) && (v.Y == 0))
                return true;
            else
                return false;
        }

        public static bool operator &(Arrow arr1, Arrow arr2)
        {
            bool arr1flag = !((arr1.X == 0) && (arr1.Y == 0));
            bool arr2flag = !((arr2.X == 0) && (arr2.Y == 0));

            return arr1flag & arr2flag;
        }

        public static bool operator |(Arrow arr1, Arrow arr2)
        {
            bool arr1flag = !((arr1.X == 0) && (arr1.Y == 0));
            bool arr2flag = !((arr2.X == 0) && (arr2.Y == 0));

            return arr1flag | arr2flag;
        }

        public static bool operator ^(Arrow arr1, Arrow arr2)
        {
            bool arr1flag = !((arr1.X == 0) && (arr1.Y == 0));
            bool arr2flag = !((arr2.X == 0) && (arr2.Y == 0));

            return arr1flag ^ arr2flag;
        }

        public static bool operator !(Arrow v)
        {
            return ((v.X == 0) && (v.Y == 0));
        }

        public double Size
        {
            get
            {
                return Math.Sqrt(arr_x * arr_x + arr_y * arr_y);
            }
        }

        public static bool operator ==(Arrow arr1, Arrow arr2)
        {
            return (arr1.X == arr2.X && arr1.Y == arr2.Y);
        }

        public static bool operator !=(Arrow arr1, Arrow arr2)
        {
            return (arr1.X != arr2.X || arr1.Y != arr2.Y);
        }

        public static bool operator >(Arrow arr1, Arrow arr2)
        {
            return (arr1.Size > arr2.Size);
        }

        public static bool operator <(Arrow arr1, Arrow arr2)
        {
            return (arr1.Size < arr2.Size);
        }

        public static bool operator >=(Arrow arr1, Arrow arr2)
        {
            return (arr1.Size >= arr2.Size);
        }

        public static bool operator <=(Arrow arr1, Arrow arr2)
        {
            return (arr1.Size <= arr2.Size);
        }

        public static implicit operator double(Arrow arr)
        {
            return arr.Size;
        }

        public static explicit operator float(Arrow arr)
        {
            return (float)arr.Size;
        }
    }
}
