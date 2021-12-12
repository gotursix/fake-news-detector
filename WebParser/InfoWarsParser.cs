using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParser
{
    public class InfoWarsParser : Website
    {
        private Dictionary<string, string> elementsClass = new Dictionary<string, string>()
        {
            { "Date", "//a[@class='css-ziaiw7']" },
            { "Content", "//div[@class='css-6lqlxw']" },
            { "Title", "//head/title" },
            { "Subject", "//p[@class='css-7nhjp']" }
        };
        public InfoWarsParser(string link) : base(link)
        {
            ExtractTitle();
            ExtractContent();
            ExtractDate();
            ExtractSubject();
        }

        protected override void ExtractContent()
        {
            HtmlNode node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Content"]);
            foreach (HtmlNode pNode in node.SelectNodes("//p"))
                Content += HtmlEntity.DeEntitize(pNode.FirstChild.InnerText) + "\n";
        }

        protected override void ExtractDate()
        {
            var numberFormat = new string[] { "th", "st", "nd", "rd"};
            HtmlNode node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Date"]);
            string dateStr = node.InnerText;
            var comma = dateStr.IndexOf(",");
            dateStr = dateStr.Substring(0, comma);
            foreach(var format in numberFormat)
                if(dateStr.Contains(format))
                    dateStr = dateStr.Remove(dateStr.IndexOf(format), 2);
            Date = DateTime.Parse(dateStr);
        }

        protected override void ExtractSubject()
        {
            HtmlNode node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Subject"]);
            Subject = node.InnerText;
        }

        protected override void ExtractTitle()
        {
            Title = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Title"]).InnerText.ToString();
        }
        
    }
}
