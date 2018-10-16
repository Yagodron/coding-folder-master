using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_lect
{
    abstract class UserInfo
    {
        protected string Usr_name;
        protected byte Usr_nmbr;

        public UserInfo(string User_Name, byte User_Number)
        {
            Usr_name = User_Name;
            Usr_nmbr = User_Number;
        }

        //abstract method
        public abstract string User_Info();
    }
}
