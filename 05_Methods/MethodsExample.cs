using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExmaples
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        //below example with int
        public int AddTwoNumber(int numOne, int numTwo)
        {
            int Sum = numOne + numTwo;
            return Sum;
        }
        //below example with double
        //however they both are the same
        public double AddTwoNumber(double numOne, double numTwo)//(=> numOne + numTwo;) is an example of lamda
            // if used lamda then we don't have to do bellow two steps

        {
            double sum = numOne + numTwo;
            return sum;
        }
        //belwo exmaple age 
        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInyears = ageSpan.TotalDays / 356.25;
            //below is converting above doble into int

            int years = Convert.ToInt32(Math.Floor(totalAgeInyears));
            return years;

        }

        [TestMethod]
        public void MethodExcution()
        {

            //below is connected with the first method created on top once

            SayHello("Banana");
            SayHello("Bob");
            int Sum = AddTwoNumber(42, 75);
            Console.WriteLine(Sum);
            // below going to return sum value in 2 decimal place
            double doubleSum = AddTwoNumber(12.2, 43.6);

            int myAge = CalculateAge(new DateTime(1901, 05, 23));
            Console.WriteLine("My age:" + myAge);

     
    }

}
}