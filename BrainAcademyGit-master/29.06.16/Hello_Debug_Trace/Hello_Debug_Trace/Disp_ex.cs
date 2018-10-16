using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello_Debug_Trace
{
    class Disp_ex : IDisposable
    {
    TextReader rdr = null;    
    public Disp_ex(string path)
    {
        Console.WriteLine("Obtaining Managed Resources");
        rdr = new StreamReader(path);

        Console.WriteLine("Obtaining Unmanaged Resources");     
        // nothing for test      
    }
    void ReleaseManagedResources()
    {
        Console.WriteLine("Releasing Managed Resources");
        if (rdr != null)
        {
            rdr.Dispose();
        }
    }
    void ReleaseUnmanged()
    {
        Console.WriteLine("Releasing Unmanaged Resources");
    }
    public void Show()
    {
        //Emulate class usage
        if (rdr != null)
        {
            Console.WriteLine(rdr.ReadToEnd() + " /some unmanaged data ");
        }
    }
            
    public void Dispose()
    {
        Console.WriteLine("Dispose");
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        Console.WriteLine("Actual Dispose " + disposing.ToString());
        if (disposing == true)
        {
            ReleaseManagedResources();
        }
        else
        {
            // Do nothing
        }
        ReleaseUnmanged();
    }        
    ~Disp_ex()
    { //Destructor
        Dispose(false);
    }
}



}
