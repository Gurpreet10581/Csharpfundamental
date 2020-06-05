using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanChallenge
{public enum GessedChar {Car, Fish, House, River  }
    public class HangmanClasses
    {
        public Random randomWord { get; set; }
        public string activeWord { get; set; }
        public int activeWordLenght { get; set; }
        public int lifeCount { get; set; }
       public GessedChar potentialWords { get; set; }

        public void Main()
        {
            Random randomWord = new Random();
            BeginGame();

        }

        public void BeginGame

       
        


        
    }
}
