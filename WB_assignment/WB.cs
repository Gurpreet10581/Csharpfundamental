using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WB_assignment
{
    [TestClass]
    public class WB
    {
        [TestMethod]
        public int SubtactTwoNumber()
        {
           int numOne = 50;
           int numTwo = 36;

            int Sub = numOne - numTwo;
           Console.WriteLine(Sub);
            return Sub;
        }

    }
    


}
