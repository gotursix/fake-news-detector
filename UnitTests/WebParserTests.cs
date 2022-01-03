using System;
using System.Globalization;
using NUnit.Framework;
using WebParser;

namespace UnitTests
{
    public class WebParserTests
    {
        [Test]
        public void Check_Content_From_Parser_For_Subject()
        {
            Website webParser = new InfoWarsParser("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/");
            Assert.AreEqual("Politics", webParser.Subject);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Title()
        {
            Website webParser = new InfoWarsParser("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/");
            Assert.AreEqual("Video: Biden Self-Owns On Inflation When Explaining Rising Meat Prices", webParser.Title);
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Date()
        {
            Website webParser = new InfoWarsParser("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/");
            Assert.AreEqual("01/03/2022 00:00:00", webParser.Date.ToString(CultureInfo.InvariantCulture));
        }
        
        [Test]
        public void Check_Content_From_Parser_For_Link()
        {
            Website webParser = new InfoWarsParser("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/");
            Assert.AreEqual("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/", webParser.Link);
        }

    }
}