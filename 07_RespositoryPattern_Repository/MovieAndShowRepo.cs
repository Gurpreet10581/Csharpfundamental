using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RespositoryPattern_Repository
{// this repository is for Show and Movie files
    // it is going to be inheriant from StreamingContentRe[psoitory file since methods have been created in it already
    class MovieAndShowRepo: StreamingContentRepository
    {
        //first method below to get shows by title 
        // also sting the title since we want the show by Title
        public Show GetShowByTitle( string title)
        {
            // by doing below we are going through everything in content directory 
            foreach(StreamingContent content in _contentDirectory)
            {
                //creating if statement setup to get show- connected capital Title to title and content to shows
                // one = meaning assigning value to something and == means compairing if two items equal
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    //return statment for if statement created above
                    //casing show in content since it is inheritant from the streaming content file
                    return (Show)content; 
                }
            }
            // using null as return because we only want to return title and if that doesn't return we don't want systme to return anything else
            return null;
            //above method is done

        }
        // below code is to get all shows
        public List<Show> GetAllShows()
        {
            //creating list of shows below
            List<Show> allShows = new List<Show>();

            // creating foreach loop below- we used StreamingContent because it is already connected with StramingContentRepository
            // since both repo and content file are connect we are able to get info from _contentDirectory
            foreach(StreamingContent content in _contentDirectory)
            {//have to create belwo if statement  to call out show
                if (content is Show)
                {//if statement body below but the actual statment is in the () above after if
                    allShows.Add((Show)content);
                }
            }
            // below step to ask for the return/result of above code.
            return allShows;
        }










        //practice below with moviebyTitle and allMovies

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {//ToLower, GetType, and typeof in the code below was default in the system just had to select it
                //ToLower makes Title into title and puts everyting else as one case
                //so as when someone searches for the movie Titanic but they put into the search titanic ...the correct movie will still come up
                //GetType is referring to the types in the list _contentDirectory which is a list of all StreamingContent
                //StreamingContent types are Movies and Shows
                //so you want to get the type of streaming content you are looking for
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

       
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }
    }

}
