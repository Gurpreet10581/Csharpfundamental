
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RespositoryPattern_Repository
{
    // make sure blew class has public infront of it all the time or else it will turn into private automaticlly 
     public class StreamingContentRepository
    // _-underscore is a must to name it. we have connected the other C# file below to obtain the list we created in it. Readonly is used to just read the content from last file and it wouldn't allow to change the values.
    // without = new List<StreamingContent>(); can not use stack or heaps- List is a reference type or value type go in stack and heap holds object and its value. 
     {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        // below we creating methods using CRUD and it will include- create, read, udate, and delete your object.
        // public= excess modifire
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true: false;
            return wasAdded; 
            //_contentDirectory.Add(content);
        }
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }

            }
            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent updatedContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = updatedContent.Title;
                oldContent.RunTimeInMin = updatedContent.RunTimeInMin;
                oldContent.ReleaseDate = updatedContent.ReleaseDate;
                oldContent.IsFamilyFriendly = updatedContent.IsFamilyFriendly;
                oldContent.TypeOfGenre = updatedContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(StreamingContent streamingContent)
        {
            bool deleteResult = _contentDirectory.Remove(streamingContent);
            return deleteResult;
        }
        
     }
}
