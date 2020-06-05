using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{// make it from public and inhertant from animal
   public class Sloth : Animal
    {
        // making a bool bleow and st is as return true for IsSlow
        public bool IsSlow
        {
            get { return true; }
        }

            //calling the move method from animal 
            public override void Move()
        {// deleted the default and added cw
            Console.WriteLine( "The Sloth moves slowly!");
            }
    }

    // connecting Megatherium by intheritanting sloth and animal and adding new statement because otherwise it was going to say the 
    // previous one created in the animal section which is  Console.WriteLine($"This {GetType().Name} moves.");
    public class Megatherium: Sloth
    {
        public override void Move()
        {
            Console.WriteLine("Megatherium uses Move! It's not super effective.....");
        }
    }
    
}
