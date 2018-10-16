using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_lect
{
    class UserGroup : UserInfo
    {
        string Group;

        public UserGroup(string User_Group, string User_Name, byte User_Number)
            : base(User_Name, User_Number)
        {
            Group = User_Group;
        }

        // Override User_Info
        public override string User_Info()
        {
            return Group + " " + Usr_name + " " + Usr_nmbr;
        }
    }
}
