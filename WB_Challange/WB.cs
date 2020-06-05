using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WB_Challange
{
    [TestClass]
    public class WB
    {
        [TestMethod]
        public void Subtract()
        {
            int numOne = 50;
            int numTwo = 36;

            int Sub = numOne - numTwo;
            Console.WriteLine(Sub);
             
        }
        [TestMethod]
        public void Variables()
        {
            string name = "Gurpreet";
            int number = 30;
            DateTime date = new DateTime(1989, 08, 02, 12, 01, 01);
            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(date);

        }

        [TestMethod]
        public void Question5()
        {
            bool daylight = true;
            bool rain = true;

            if (daylight)

            {
                
                Console.WriteLine("It is during the day.");
            }
            if (rain= true)
            {
                Console.WriteLine("It is raining.");

            }
            else
            {
                Console.WriteLine("It is night time");
            }

        }

        [TestMethod]
        public void Switch()
        {
            Console.WriteLine("Are you wearing clothes?");
            string input = "Yes";
            switch (input)
            {
                case "Yes":
                    Console.WriteLine("Congrats You are wearing clothes.");
                    break;
                case "No":
                    Console.WriteLine("It is cold you better wear something!");
                    break;
            }
        }
    }

}
