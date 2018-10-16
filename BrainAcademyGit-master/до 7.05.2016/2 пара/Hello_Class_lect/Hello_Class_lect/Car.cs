using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_lect
{
    class Car
    {      
        string color; //Constructor
        public Car()
        {
   
        }

        public Car(string color) //Constructor
        {
            color = "Red";
        }

        ~Car()  //Destructor
        {
            Console.WriteLine("Destroy car ...");
        }
    }
}
