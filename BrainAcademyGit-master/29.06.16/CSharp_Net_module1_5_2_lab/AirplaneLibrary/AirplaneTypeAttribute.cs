using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneLibrary
{
    // 1) add enum AirplaneTypes with values SportPlane, CargoPlane, TurboProp, Jet
    public enum AirplaneTypes { SportPlane, CargoPlane, TurboProp, Jet };

    // 2) set attribute AttributeUsage with parameters that allow to use class AirplaneTypeAttribute
    // for classes only, disable inheritance and enable multiple using

    // 3) derive class AirplaneTypeAttribute from System.Attribute and protect against inheritance
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class AirplaneTypeAttribute : Attribute
    {

        // 4) declare public property Type with type - AirplaneTypes 
        public AirplaneTypes Type;
        // 5) declare 2 constructors:
        // default - initialize Type  with AirplaneTypes.TurboProp
        public AirplaneTypeAttribute()
        {
            this.Type = AirplaneTypes.TurboProp;
        }
        // parameter - with type AirplaneTypes 
        public AirplaneTypeAttribute(AirplaneTypes type)
        {
            this.Type = type;
        }
        //add two AirplaneTypeAttribute-s to UniversalAirplane

        //add AirplaneTypeAttribute to CargoAirplane
    }
        [AirplaneType(AirplaneTypes.CargoPlane)]
        [AirplaneType(AirplaneTypes.Jet)]
        public class UniversalAirplane
        {
            public string Name { get; set; }
            public UniversalAirplane()
            {
                Console.WriteLine("lol universal");
            }
        }

        [AirplaneType(AirplaneTypes.CargoPlane)]
        public class CargoAirplane
        {
            public string Name { get; set; }
            public CargoAirplane()
            {
                Console.WriteLine("lol cargo");
            }
        }
}
