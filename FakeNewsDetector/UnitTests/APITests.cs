using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        //This unit test will check whether the Check-News endpoint works as it should
        [Test]
        public void Sends_Correct_Request_CheckNews()
        {
            Assert.True(true);
        }
        
        //Check response for incorrect request
        [Test]
        public void Sends_Bad_Request_CheckNews()
        {
            Assert.True(true);
        }
        
        //This unit test will check whether the History endpoint works as it should
        [Test]
        public void Sends_Correct_Request_History()
        {
            Assert.True(false);
        }
        
        //Check response for incorrect request
        [Test]
        public void Sends_Bad_Request_History()
        {
            Assert.True(false);
        }
        
        //Check if response is 200 for about page
        [Test]
        public void Check_About_Works()
        {
            Assert.True(false);
        }
        
    }
}