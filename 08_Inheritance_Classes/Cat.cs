using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{//added public and  :animal below to connect it with the Animal page/class
    // using Cat as one example to run the test for Animal
    // This file was created under Unit Test
    public class Cat: Animal
    {
        // any thing like int or decimal can be used instead of double below it is personal preference 
        public double ClawLenth { get; set; }

        public Cat()
        {
            HasFur = true;
            TypeOfDiet = DietType.Carnivore;
        }
        // using vertual below from Animal file also changed the last part moves to moves quickly now
        public override void Move()
        {
            Console.WriteLine($"{GetType().Name} moves quickly");
        }

        // vertual method inside cat method below
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    /// below is inheritaning from cat and cat is inheritaning from the Animal file
    public class Liger: Cat
    {
        // changed the vertual for Liger since it doesn't makes the  Meow sound
        public override void MakeSound()
        {
            // defulted  was deleted and CW tab tab was added and filled below
            Console.WriteLine("Roar");
        }
        // created another class with in class for different feature and added Consle writle line above default one
        public override void Move()
        {
            Console.WriteLine($" the {GetType().Name} stalks its prey.");
            base.Move();
        }
    }
}
