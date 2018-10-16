using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var universalPlane = new AirplaneLibrary.Classes.UniversalAirplane();
            Type AirplaneType = universalPlane.GetType();
            var _fields = AirplaneType.GetMethods();
            foreach (var field in _fields)
            {
                Console.WriteLine("{0} {1}", field.Name, field.ReturnType.Name);
            }


            Type t = typeof(AirplaneLibrary.Classes.UniversalAirplane);
            Attribute[] attrbs = Attribute.GetCustomAttributes(t);
            foreach (AirplaneLibrary.AirplaneTypeAttribute attr in attrbs)
            {
                Console.WriteLine("kak {0}", attr.Type);
            }

            //AirplaneLibrary.AirplaneTypeAttribute[] attrs = AirplaneLibrary.AirplaneTypeAttribute.GetCustomAttributes(t);
            //foreach (Attribute attr in attrs)
            //{
            //    Console.WriteLine("kak {0}", attr);
            //}

            Console.ReadLine();
        }
    }
}
