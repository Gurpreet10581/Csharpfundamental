using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Intro// this is new class
{
    public interface IFruit// changed it to public interface
    {
        //interface doesn't have access modifier meaning not publi class
        //have to make sure  any classes you create in future inheritaning this file must have below
        string Name { get; }// don't have to put set; here since it is an interface method

        bool Peeled { get; }
        string Peel();// give this a value in the FruitClasses file
    }
}
