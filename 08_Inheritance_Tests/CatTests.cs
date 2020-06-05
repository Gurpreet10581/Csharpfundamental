using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]

    // changed the name belwo to CatTests
    public class CatTests

    {
        [TestMethod]
        public void TestMethod1()
        {
            // ctrl . to connect/reference the Cat to the Cat file
            // newing up the belwo infomation 
            Cat firstCat = new Cat();
            firstCat.MakeSound();
            firstCat.Move();

            //doing it for liger now referencing and newing up stff

            Liger firstLiger = new Liger();
            firstLiger.MakeSound();
            firstLiger.Move();

            // connected the list with animial to cat and liger
            List<Animal> test = new List<Animal>();
            test.Add(firstCat);
            test.Add(firstLiger);     
        }
    }
}
