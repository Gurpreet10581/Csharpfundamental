using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    // create enum and labled it Herbivore=1 or any# because it followes indexing of all and will start with 0 as default
    public enum DietType { Herbivore=1, Omnivore, Carnivore}
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }
        public bool BreathsAir { get; set; }

        //bring the enum created above below
        
        public DietType TypeOfDiet { get; set; }

        //Constructer below- which blank so it can be connected with Cat file
        public Animal () { }
        /// vertual belwo to use it as override for next file
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
}
