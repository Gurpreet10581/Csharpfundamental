﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopsExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total != 10) 
            {
                Console.WriteLine(total);
                total += 1;

            }
            total = 0;
            while(true)
            {
                if (total == 10)
                {
                    Console.WriteLine( "Goal Reached");
                    break;
                }
                total++;
            }
            Random rand = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if(someCount==6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount== 15)
                {
                    keepLooping = false;
                }
            }
        }
        [TestMethod]
        public void ForLoops()
            
        {
            int studentCont = 18;
            for ( int i= 0; i<=studentCont; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Dylan", "Christa", "Erin", "Kevin", "Greg", "Justin" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there, {students[i]}i");
            }

        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Lauren", "Un Yon", "Jonathan", "Seth", "Gopi", "Sydney", "Carson", "Michael" };
            foreach(string hooligan in students)
            {
                Console.WriteLine(hooligan + " is here And that is nice");
            }
            string myname = "Hooligan One";
            foreach (Char letter in myname)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Ice cream please.");
                iterator++;
            }
            while (iterator < 5);


            do
            {
                Console.WriteLine("Even with a false");
            }
            while (false);
            {
                Console.WriteLine("Yo");
            }
        }
    }
}
