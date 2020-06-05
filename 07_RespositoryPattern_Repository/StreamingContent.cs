using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RespositoryPattern_Repository
{
    public enum GenreType 
    {
        Horror= 1,
        Scifi,
        Bromance,
        Action,
        Fantasy,
        Comedy,
        Darama,
        Crime
    }

    public class StreamingContent
        //below is a class until line 42
    {
        public string Title { get; set; }
        public int RunTimeInMin { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public bool IsFamilyFriendly { get; set; }

        ///Constructers bleow for enum
       
            //below is bogus one to avoid creating overloaded every step
        public StreamingContent() { }

        // below is done to assign property-it is called overloaded.
        public StreamingContent(string title, int runTime, DateTime releaseDate, GenreType type, bool familyFriendly)
        {
            Title = title;
            RunTimeInMin = runTime;
            ReleaseDate = releaseDate;
            TypeOfGenre = type;
            IsFamilyFriendly = familyFriendly;

        }
    }
}
