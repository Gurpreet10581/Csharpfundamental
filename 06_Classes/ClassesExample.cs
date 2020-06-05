using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    // enum=set type ( create your own type)
    public enum VehicleType { Car, Truck, StationWagon, Suv, Motercycle, ATV, Spaceship, Boar, HorseAndBuggy }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Mileage { get; set; }

        // Connected the above enum- without it no use of enum above
        public VehicleType TypeOfVehicle { get; set; }

        // Constructor below empty one
        public Vehicle() { }

        // Overloaded Constructor below

        public Vehicle(string make, string model, decimal mileage, VehicleType type
            )
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }

    }
    // using it for Person
    public class Person
    {
        public string FristName { get; set; }
        private string _lastName;
        public string LastName
        {

            get { return _lastName; }
            set { _lastName = value; }

        }

        public string FullName
        {
            get { return $"{FristName} {LastName}"; }

        }
        public DateTime DOB { get; set; }

       public int Age
        {
            get
            {
                if (DOB== new DateTime())
                {
                    return 90001;
                }
                TimeSpan timeSpan = DateTime.Now - DOB;
                double totalAgeInYears = timeSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld; 
            }
        }
        public bool IsAdult
        {
            get
            {
                if (Age >=21)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
        }
        // empty constructor 
        public Person() { }
        //overloaded constructor
        public Person( string fristname, string lastName, DateTime dob)
        {
            FristName = fristname;
            LastName = lastName;
            DOB = dob;
        }
    }
    
   
}
