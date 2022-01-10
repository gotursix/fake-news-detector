using System.Globalization;
using NUnit.Framework;
using WebParser;

namespace UnitTests
{
    public class WebParserNbcTests
    {
        [Test]
        public void Check_Content_From_Parser_For_Subject()
        {
            Website webParser = new NbcParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("Coronavirus", webParser.Subject);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Title()
        {
            Website webParser = new NbcParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("Covid is rampant among deer, research shows", webParser.Title);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Date()
        {
            Website webParser = new NbcParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("01/03/2022 15:53:09", webParser.Date.ToUniversalTime().ToString(CultureInfo.InvariantCulture));
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Link()
        {
            Website webParser = new NbcParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181", webParser.Link);
        }
    }
}