using System;
using _07_RespositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Test
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //creating object below to test
            StreamingContent content = new StreamingContent();

            content.Title = "Aladdin";
            string expected = "Aladdin";
            string actual = content.Title;

            //Assert is the console write like for multiple lines instead of one at a time

            Assert.AreEqual(expected, actual);


        }

    }
}
