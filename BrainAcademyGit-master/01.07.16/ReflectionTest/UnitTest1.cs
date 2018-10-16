using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AirplaneLibrary.Classes;
using System.Reflection;

namespace ReflectionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            //arrange
            Type t = typeof(AirplaneLibrary.Classes.CargoAirplane);
            Assembly assy = t.Assembly;
            Attribute attrb = Attribute.GetCustomAttribute(assy,t);
            bool f = false;
            //act
            //Assert.AreEqual(attrb, AirplaneLibrary.AirplaneTypes.CargoPlane)
        }
    }
}
