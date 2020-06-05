using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{// this file is created in Console app
    // this part is the front part of streaming files we created earlier which was back end of the program
    class Program
    {// following is default static void Main(string[] args) when you create the file
        //Main is used for run we don't use this much
        //to start we will have to go to UI file first 
        static void Main(string[] args)
        {
            //calling run method below created in UI
            //below newing up an instance crated in other file or connecting them 
            ProgramUI ui = new ProgramUI();
            //calling run method below 
            ui.Run();
        }
    }
}
