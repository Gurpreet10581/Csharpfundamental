using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challanges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintingLetters()
        {
            string longWord = "Supercalifragilisticexpialidocious";// writting every char
            foreach (char letter in longWord)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine();//writes above code

            foreach (char letter in longWord)// writting i or not i
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
            Console.WriteLine();//writes above code

            int count = 0; //countting letters in the word
            foreach (char letter in longWord)
            {
                count++;
            }
            Console.WriteLine("The letters equal to: " + count);
            Console.WriteLine();
            //counting letters above

            foreach (char letter in longWord)//determin i or L
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or an L");
                }
            }
        }
    }

}
