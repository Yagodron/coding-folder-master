using System;

namespace Hello_Events_lect
{
    class Birds_EventArgs : EventArgs
    {
            public bool BirdFlewAway { get; set; }
            public DateTime TimeReached { get; set; }
        
    }
}
