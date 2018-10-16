using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    static class MyStaticClass
    {
        public static int stat_x;
        static MyStaticClass()
        {
            stat_x = 0;
        }
        public static void StatMethod(int par)
        {
            stat_x = par;
        }
    }

}
