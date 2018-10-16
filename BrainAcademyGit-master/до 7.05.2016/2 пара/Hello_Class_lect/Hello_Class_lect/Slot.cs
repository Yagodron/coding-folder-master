using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_lect
{
    class Slot
    {
        int slot_width;
        int slot_height;

        public int slot_Width
        {
            get { return slot_width; }
            set { slot_width = value; }
        }

        public int slot_Height
        {
            get { return slot_height; }
            set { slot_height = value; }
        }

        public int slot_Lengthwise { get; set; }
    }
}
