using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ClassesToBeTested;

namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void Check_Correct_Division()
        {
            //arrange
            double arg1 = 4.0;
            double arg2 = 2.0;
            double expected = 2.0;
            //act
            double actual = arg1 / arg2;
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod,
        ExpectedException(typeof(DivideByZeroException))]
        public void Check_Exception_Division()
        {
            //arrange
            int arg1 = 1;
            int arg2 = 0;
            //act
            int actual = arg1 / arg2;
        }

        [TestMethod]
        public void Check_Constr_With_No_Param()
        {
            //arrange
            string name = "unnknown";
            double amount = 0.0;
            bool hasCard = false;
            //act
            Customer testCust = new Customer();
            //assert
            Assert.AreEqual(name, testCust.Name);
            Assert.AreEqual(amount, testCust.Amount);
            Assert.AreEqual(hasCard, testCust.HasCard);
        }

        [TestMethod]
        public void Check_Constr_With_Param()
        {
            //arrange
            string name = "John";
            double amount = 150.0;
            bool hasCard = true;
            //act
            Customer testCust = new Customer(name, amount, hasCard);
            //assert
            Assert.AreEqual(name, testCust.Name);
            Assert.AreEqual(amount, testCust.Amount);
            Assert.AreEqual(hasCard, testCust.HasCard);
        }

        [TestMethod]
        public void Check_IsEnough_Success()
        {
            //arrange
            string name = "John";
            double amount = 150.0;
            bool hasCard = true;
            Customer testCust = new Customer(name, amount, hasCard);
            double sum = 100.0;
            //act
            bool isSuccess = testCust.IsEnough(sum);
            //assert
            Assert.AreEqual(true, isSuccess);
        }
    }
}
