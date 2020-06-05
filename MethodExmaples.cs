using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_methods
{
    [TestClass]
    public class MethodExmaples
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public int AddTwoNumber(int numOne, int numTwo)
        {
            int Sum = numOne + numTwo;
            return Sum;
        }
           public double AddTwoNumber(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInyears = ageSpan.TotalDays / 356.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInyears));
            return years;

        }

        [TestMethod]
        public void MethodExcution()
        {
            SayHello("Banana");
            SayHello("Bob");
            int Sum = AddTwoNumber(42, 75);
            Console.WriteLine(Sum);

            double doubleSum = AddTwoNumber(12.2, 43.6);

            int myAge = CalculateAge(new DateTime(1901, 05, 23));
            Console.WriteLine("My age:" + myAge);

        }
    }
}
