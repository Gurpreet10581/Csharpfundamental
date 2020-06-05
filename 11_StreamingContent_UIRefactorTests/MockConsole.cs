using _11_StreamingContent_UIRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactorTests
{
    public class MockConsole: IConsole // will have to add reference since it is not in the same assembly
    {
        public Queue<string> UserInput; //Queue are first in first out so it has to be in an ordere 
        public string Output;

        //constucter below
        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = "";//setting as an empty screen
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo(); // returning empty object
        }
        public string ReadLine()
        {
            return UserInput.Dequeue();
        }
        public void Write(string s)
        {
            Output += s;
        }
        public void WriteLine(string s)
        {
            Output += s + "\n";
        }
        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
