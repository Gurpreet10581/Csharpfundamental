using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Intro
{
    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }// did this to setup the name as Banana for ever
        }
        public bool Peeled { get; private set; }//Peeled is a property/ Private=it could only be called in this class=Peeled



        public string Peel()
        {
            Peeled = true;
            return "You peeled the banana.";
        }

        public Banana() { } // empty constructer
        public Banana(bool isPeeled) // constructer with a bool
        {
            Peeled = isPeeled;
        }
    }
    public class Orange: IFruit
    {
        public String Name
        {
            get { return "Orange"; }
        }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the orange";

        }
        public string squeeze()/// also creating squeeze since it is an orange
        {
            return "You squeeze the orange and juice comes out!";
        }
    }
    public class Grape: IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }
        public bool Peeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}
