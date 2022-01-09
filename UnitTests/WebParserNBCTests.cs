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
            Website webParser = new NBCParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("Coronavirus", webParser.Subject);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Title()
        {
            Website webParser = new NBCParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("Covid is rampant among deer, research shows", webParser.Title);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Date()
        {
            Website webParser = new NBCParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("12/30/2021 00:00:00", webParser.Date.ToString(CultureInfo.InvariantCulture));
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Link()
        {
            Website webParser = new NBCParser("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181");
            Assert.AreEqual("https://www.nbcnews.com/science/science-news/covid-rampant-deer-research-shows-rcna10181", webParser.Link);
        }
    }
}