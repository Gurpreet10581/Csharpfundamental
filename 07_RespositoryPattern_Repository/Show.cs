using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RespositoryPattern_Repository
{// make it public
    //inheritant it to Streaming Content
    public class Show: StreamingContent
    {
        // setting properties for show class below

        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }

        // make a list property for below class to connect and work
        public List<Episode> Episodes { get; set; }
    }
    // properties for episodes below 
    // make a episode calss first
    public class Episode
    {
        // Episode proerties below
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
