using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {// you do belwo if you are not creating overloaded constructer 
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 250000.1m;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            string carDetails = $"{firstVehicle.Make} {firstVehicle.Model}";
            Console.WriteLine(carDetails);

            Vehicle anotherV = new Vehicle("Toyota", "Corolla", 890000.42m, VehicleType.Spaceship
                );
            
        }

        [TestMethod]
        public void PersonTests()
        {
            //below we created overloaded constructer 
            Person firstPerson = new Person("Bella", "Knight", new DateTime (1505, 01, 29));
            Console.WriteLine($"{firstPerson.FullName} is {firstPerson.Age} years old!");

            Person blankPerson = new Person();
            Console.WriteLine($"{blankPerson.FullName} is {blankPerson.Age} years old!");

        }

    }
}
