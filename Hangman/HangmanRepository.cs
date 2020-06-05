using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanRepository
    {
        protected readonly List<HangmanContent> _wordDirectory = new List<HangmanContent>();

        public List<string> pullWords = new List<string>() { "Car ", "Fish", "House", "River", "Dog", "Bat", "Cat", "Rat", "Bike", "King", "\n" +
            "cycle", "Boggle", "Injury", "Funny", "Jogging", "Joking", "Puppy", "Quiz", "Scratch", "Subway", "\n"+
            "Zombie", "Witchcraft", "Syndrome", "Razzmatazz", "Grogginess", "Askew", "Croquet", "Espionage", "Jiujitsu", "Xylophone" };
        public string StartPlaying(HangmanContent pullWords)
        {
            int startingCount = _wordDirectory.Count;
            _wordDirectory.Add(pullWords);
            string levelSelected = (_wordDirectory.Count == startingCount) ? "You have now selected your level" : "Please select a level";
            return levelSelected;
        }
        public string Pullwords()
        {
            var random = new Random();
            int index = random.Next(pullWords.Count);
            string ActiveWord = pullWords[index].ToString();
            return ActiveWord;
        }

        public int NumberOfLetter(string ActiveWord)
        {
            char[] letters = ActiveWord.ToCharArray();
            int number = letters.Length;
            return number;
        }
        // tell the user the positon of the guessed char in the word 


        public string PlayingTheGame(string activeWord)
        {
            char[] letter = new char[activeWord.Length];
            for (int w = 0; w < letter.Length; w++)
            {
                letter[w] = '-';
            }
            for (int w = 0; w < letter.Length; w++)//number of letters via underscores
            {
                Console.WriteLine(letter[w] + " ");
            }
            Console.WriteLine();
            int count = 0;
            do
            {
                ////UI requesting a guess.
                char input = Console.ReadLine().ToCharArray()[0];
                for (int w = 0; w < activeWord.Length; w++)
                {
                    if (activeWord[w] == input)///if correct
                    {
                        count++; ///update count to check upon exit
                        letter[w] = input; ///replacing the dash
                        for (int l = 0; l < activeWord.Length; l++)
                        {
                            Console.WriteLine(letter[l] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
            while (count < activeWord.Length);


            else { 

            if ()
            while (playHangman.Result() == Player.CONTINUE)
            {
                Console.Write("Pick a letter --> ");
                ConsoleKeyInfo guessedLetter = Console.ReadKey();
                if (playHangman.AddGuessedLetters(guessedLetter.KeyChar))
                    playHangman.Play();
            }
            if (playHangman.Result() == Player.LOSE)
            {
                Console.WriteLine("So sorry. You struck out.");
                return;
            }
            else
            {
                Console.WriteLine("You won !", 500);
                return;
            }
        }
    }

      
    }

    public class PlayerRepo
    {
        //create the name space in UI with CW

        public int LifeCount()
        {

        }



    }
}

