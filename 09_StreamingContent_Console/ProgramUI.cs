using _07_RespositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{// this runs user interface
    public class ProgramUI
    { //making a field below after all the codes are added so it can work// field exists for whole calls unlike variable only stays with in method
        // the _ infront of the word makes it a field
        //below made it private and readonly so it is cmmunicating it properly 
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        public void Run()
        {//building method for test data so when you run test there is data to play with next part where method is created will be under ShowByTitle method
            SeedContentList();
            //calling a method which doesn't exist yet- RunMenu(); it will have error but it will go away as we do more coding 
            RunMenu();
        }
        // adding stuff in above method and to make it real
        // making it private because we only going to excess in this file not in any other file
        private void RunMenu()
        {
            // created bool to hold our menu below 

            bool continueToRun = true;

            //while loop below  and take the last curly bracket of it under switch case create- by alt and arrow down
            // this step comes after the switch part has been created
            while (continueToRun)
            {
                // console clear created so it doesn't run the exit one or same onece again and again after user pressses enter when they dont get their result
                Console.Clear();

                //propmting/writting console below for user to do something
                //\n and enter creats a new line to add more notes 
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1) Show all streaming content \n" +
                    "2) Find streaming content by title\n" +
                    "3) Add new streaming content\n" +
                    "4) Remove streaming content\n" +
                    "5) Update\n" +// this was class challange 
                    "6) Exit");

                // belwo command to read above input
                string userInput = Console.ReadLine();

                // before running make sure it is set as startup project in the solution section by right clicking it 
                //creating switch case below for above user input created
                // make sure it is all in one switch and create a default one incase user doesn't selects out of 5 mentioned

                switch (userInput)
                {
                    case "1":
                        {// putting comment in all so you don't have to go back and check 
                         // Show All- making a content method below
                            ShowALL();
                            break;
                        }
                    case "2":
                        {//Show by title
                            ShowByTitle();
                            break;
                        }
                    case "3":
                        {//Add new content

                            CreateNewContent();
                            //above created to link to the method mentined 
                            break;
                        }
                    case "4":
                        {//Delete content
                            RemoveContent();
                            break;
                        }
                    case "5":
                        {//Update content-classChallange  
                            UpdateContent();
                            break;
                        }
                    case "6":
                        {//Exit
                            // adding loop to false since it is and Exit case
                            continueToRun = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }

                        // next step will be to put everything inside the lop 
                }
            }//this curly bracket is from while loop created above to connect the swithces created
        }

        // creating method to run when we are deciding new conscept 
        private void CreateNewContent()
        {
            //adding some logic below 
            // below so it start out clear 
            Console.Clear();

            StreamingContent content = new StreamingContent();
            //  above had to hit ctrl+. and aded referent to 07_RepositoryPattern_Repository

            // below was copied from mentioned file above and added in as a note by pressing ctrl+k+c
            // public string Title { get; set; }
            //public int RunTimeInMin { get; set; }
            //public DateTime ReleaseDate { get; set; }
            //public GenreType TypeOfGenre { get; set; }
            //public bool IsFamilyFriendly { get; set; }

            // below asking user to do so 
            Console.WriteLine("Please enter a title");

            //we are askig below from the user  so above can work
            content.Title = Console.ReadLine();


            // we are doing runtme belwo 
            Console.WriteLine("Please enter the runtime in minutes:");

            // adding below for user and changing it to int since it is going to be a number 
            // by adding int.Parse()around the console.readline- basically it is a converstion method
            // we did that because read line always returns string so we have to int it to get runtime

            content.RunTimeInMin = int.Parse(Console.ReadLine());

            //Genre type and we are connecting enum below  and adding the different one we had in the enum
            Console.WriteLine("Select a Genre \n" +
                "1) Horror \n" +
                "2) Scifi \n" +
                "3) Bromance \n" +
                "4) Action \n" +
                "5) Famtasu \n" +
                "6) Comedy \n" +
                "7) Daram \n" +
                "8) Crime");

            //now we will have to call the Genre type below 
            //below printing valuse of enum without adding one by one
            // var created  arrey
            //example below- does the same thig as above CW line

            //var test = Enum.GetValues(typeof(GenreType));

            ////setting value of i=1
            //var i = 1;
            //foreach  (var me in test)
            //{
            //    Console.WriteLine($"{i}){me}");
            //    // +1 for value of i
            //    i+= 1;
            //}
            //Console.ReadLine();

            // below is catching what ever user says hopefully the will pick from what we had provided or it would work options are1-8
            string genreChoice = Console.ReadLine();

            // casting above response from user into an enum below with few step
            // converting above string to int 
            int genreID = int.Parse(genreChoice);

            // below changing (GenreType) to genreID or casting it another words
            content.TypeOfGenre = (GenreType)genreID;

            //below working on FamilyFriendly part

            Console.WriteLine("Is this content family friendly?");
            // above is just a statment/question for user
            // we can do this method in few ways like switch 
            // fbool=familyfrindly just gave it a randome name 

            string fBool = Console.ReadLine().ToLower();
            //next green line shows how to convert string to boolen if we don't want to use switch method
            //Convert.ToBoolean(fBool);

            //switch case below
            switch (fBool)
            {
                case "true":
                    {// just added the question=true
                        content.IsFamilyFriendly = true;
                        break;
                    }
                case "false":
                    {
                        content.IsFamilyFriendly = false;
                        break;
                    }
            }


            //Below working on DateTime
            //prompting user below and asking to do below 
            Console.WriteLine("What is the release date of this content?\n" +
                "use format: year, month,day or YYYY,MM,DD \n" +
                "Example:1943,01,24");

            //catching users response below
            // creating rdate below and readline for reading the users response
            string rDate = Console.ReadLine();

            // Now connecting rDate and ReleaseDate
            content.ReleaseDate = DateTime.Parse(rDate);


            //bringing the feild from line before all the codes below
            bool added = _streamingRepo.AddContentToDirectory(content);
            if (added)
            {
                Console.WriteLine("Your Content has been added\n" +
                    "Press any Key to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There has been an error, Please try again");
                Console.ReadLine();
            }
            // now run the code 
        }

        //making method for show all part
        private void ShowALL()
        {
            Console.Clear();

            // create a list to reach into repository and call out the file and calling GetContent and saving that reponse below
            //List<Type of list> variable name= feild.Old feild created in previous file- this how you setup below
            List<StreamingContent> listOfContent = _streamingRepo.GetContent();

            //making for eachloop now 
            foreach (StreamingContent content in listOfContent)
            {//we made below cw to show content and title
                DisplayContent(content);
            }

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        //building a contend method to display content now and  in future
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.RunTimeInMin}\n" +
                $"Genre: {content.TypeOfGenre}\n" +
                $"This content is family friendly: {content.IsFamilyFriendly}\n" +
                $"Runtime(in min): {content.RunTimeInMin}\n" +
                $"Release Date:{content.ReleaseDate}");
        }

        //below method is going to be for ShowByTitle
        private void ShowByTitle()
        {
            //adding some logic below 
            // below so it start out clear
            Console.Clear();
            // asking below to user
            Console.WriteLine("Please enter a title");
            //made a string for the method to be added/linked in the object
            string title = Console.ReadLine();
            //making an object to say our response
            StreamingContent foundContent = _streamingRepo.GetContentByTitle(title);
            //if statement and added !=null-if searched 
            if (foundContent != null)
            {
                DisplayContent(foundContent);
            }
            //else statment for above if statement 
            else
            {

                Console.WriteLine("Invalid title. Could not find any results");

            }
            //below  message to pause the sytem and give a message
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        //creating Delete part as Remove content
        private void RemoveContent()
        {
            //Prompting user below
            Console.WriteLine("Which item would you like to remove?..");
            //gathering the content collection or the option that user have by using list 
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            //below is so it start at 0
            int count = 0;
            //foreach case below
            foreach (StreamingContent content in contentList)
            {//count++ adds 1 to the int
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }
            // giving it target ID and turning into int
            int targetContentID = int.Parse(Console.ReadLine());
            //below turning into index and create if statement and subtract 1

            int targetIndex = targetContentID - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {//grabing and saving the object below
                //with index we do [] brakets
                StreamingContent desiredContent = contentList[targetIndex];
                //if within a if
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} has been removed");
                }
                // if it doesn't get deleted then add else for answer
                else { Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that."); }
            }
            //this is linked to the first if statement as its response
            else
            {
                Console.WriteLine("No content had that ID");
            }
            Console.WriteLine("Press any key to continue.......");
            // read key only read or gives option of 1 caracter where readline keeps reading rest of the code
            Console.ReadKey();
        }
        // below we are just adding data type meaning exmaples to run test for methods we created above.
        //below method is linked to the SeedContentList all the way top of the file so we can run tests. 
        //this has to be in Run method not class

        //below is the update class challange
        private void UpdateContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent();//empty object has been created for the user to fill with info.

            Console.WriteLine("Which item would you like to update? Please give Title");
            string originalTitle = Console.ReadLine();
          

            Console.WriteLine("What is the new Title ?");
            content.Title = Console.ReadLine();

           Console.WriteLine("What is the new RunTimeInMin ?");
            content.RunTimeInMin =int.Parse( Console.ReadLine());

            Console.WriteLine("What is the new ReleaseDate");
            content.ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is it still IsFamilyFriendly");
            content.IsFamilyFriendly = bool.Parse( Console.ReadLine());

            Console.WriteLine("Select a Genre [1-8] \n" +
               "1) Horror \n" +
               "2) Scifi \n" +
               "3) Bromance \n" +
               "4) Action \n" +
               "5) Famtasu \n" +
               "6) Comedy \n" +
               "7) Daram \n" +
               "8) Crime");
            int genreID = int.Parse(Console.ReadLine());
            content.TypeOfGenre = (GenreType)genreID;

           
            bool updatedContent = _streamingRepo.UpdateExistingContent(originalTitle, content);
            if (updatedContent == true)
            {
                Console.WriteLine( "Your input has been updated" );
            }
            else
            {
                Console.WriteLine("Your update request has failed.");
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.Clear();
            RunMenu();
        }
        private void SeedContentList()
        {
            StreamingContent aladdin = new StreamingContent("Aladdin", 123, new DateTime(2020, 02, 01), GenreType.Crime, true);
            _streamingRepo.AddContentToDirectory(aladdin);
            StreamingContent jack = new StreamingContent("Jack", 45, new DateTime(1345, 05, 05), GenreType.Fantasy, false);
            _streamingRepo.AddContentToDirectory(jack);
            StreamingContent bigHeroSix = new StreamingContent("Big Hero Six", 236, new DateTime(1934, 02, 02), GenreType.Bromance, true);
            _streamingRepo.AddContentToDirectory(bigHeroSix);
            StreamingContent pB = new StreamingContent("Princess Bride", 9285, new DateTime(1209, 03, 03), GenreType.Action, true);
            _streamingRepo.AddContentToDirectory(pB);

        }


    }
}
