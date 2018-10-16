using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEvents
{
    public delegate void EventDelegate();
    
    class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            if (MyEvent != null)
            {
                MyEvent.Invoke();    
            }
            
        }
    }
}
