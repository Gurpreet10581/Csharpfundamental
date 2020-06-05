using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_Intro// this file is created in Unit Test

{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()/// changed name here
        {
            IFruit banana = new Banana();//can not new IFruit which is why we did Banana
            var output = banana.Peel();
            Console.WriteLine(output);//put output
            Console.WriteLine("The banana is peeled:"+banana.Peeled);//+ to print the value of Peeled method that was created before
            Assert.IsTrue(banana.Peeled);//final step to run the test
        }

        [TestMethod]
        public void InterfacesInCollectons()
        {
            var orange = new Orange();// used var becaus it is an variable  and newed it 
            var fruitSalad = new List<IFruit>//take out() and add {} to make and add the list for the List
            {
                new Banana(),
                new Grape(),
                orange// just because oranged has been newed already so don't have to put new infront
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);//fruit.-will only share the IFruit quility not squeeze
                Console.WriteLine(fruit.Peel());
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }
            Console.WriteLine(orange.squeeze());// used it here since squeeze wasn't availabe above since it is differnt all other IFruits
        }

        private string GetFruitName(IFruit fruit)// will be using it below once ready 
        {
            return $"This fruit is called {fruit.Name}";//make sure it is same as part 2 in next method
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);//used the above method 
            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is called Grape"));// make sure it is exactly same as part one above
        }
        [TestMethod]
        public void TypeOfInstance()
        { var tomato = new Grape();/// just added it since we needed more fruit for example
            var fruitSalad = new List<IFruit>///using {} instead of () since we have to add list belwo
            {
                new Orange(),
                new Grape(),
                new Banana(true),
                new Orange(),
                new Banana(),
                tomato,
            };
            Console.WriteLine("Is the banana peeled");
            foreach(var fruit in fruitSalad)/// it is going to go through each item in fruitsalad
            {
                if (fruit is Banana banana)/// it is casing IFruit to Banana if it mathces//this line is called pattern matching
                {
                    if (banana.Peeled)
                    {
                        Console.WriteLine("Yes the banana is peeled!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry bud, this banana isn't peeled");
                    }
                }
                else if (fruit.GetType()== typeof(Grape))// this is to include Grape
                {
                    Console.WriteLine("Congrats on the Grape");
                }
                else//to have orange included
                {
                    Console.WriteLine("What a nice orange you have... to bad its not a tangerine:(");
                }
            }
        }
    }
}
