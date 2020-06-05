using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interface_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void DollarTest()//change it to Dollar since we doing that test
        {
            ICurrency dollar = new Dollar();//newing the ICurrency to Dollar
            Assert.AreEqual(1m, dollar.Value);
        }
        [DataTestMethod]//manually added it
        [DataRow(100.2)]//manually added it and also the value in ()
        [DataRow(32.44)]
        [DataRow(42.77)]
        [DataRow(432)]

        public void EPaymentTests(double value)//assined property as doule value but it can not use decimal
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
        }

    }
}
