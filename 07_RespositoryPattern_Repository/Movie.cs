using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RespositoryPattern_Repository
{// make it public
 // inheritant if from StreamingContent
    public class Movie : StreamingContent
    {// created a bool and gave it a name and added get set (UsSequel- is an example of property)
        public bool IsSequel {get; set;}

        //constructers belwo first empty one and second overloaded 
        //empty below- for background uses 
        public Movie() { }
        //overloaded below and inheritant after that all the variables from StreamingContent file so we don't have to assign it one by one. make sure they all match
        //call base class constructer- all the variable from content file (pervious file) 
        public Movie(string title, int runTime, DateTime releaseDate, GenreType type, bool isFmilyFriendly, bool isSequel): base(title,runTime,releaseDate,type,isFmilyFriendly)
        {
            //made the property into a variable(Named it)
            IsSequel = isSequel;
        }
     }
}
