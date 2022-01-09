using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace WebParser
{
    public class InfoWarsParser : Website
    {
        private readonly Dictionary<string, string> _elementsClass = new()
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

        protected sealed override void ExtractContent()
        {
            var node = HtmlDoc.DocumentNode.SelectSingleNode(_elementsClass["Content"]);
            foreach (var pNode in node.SelectNodes("//p"))
                Content += HtmlEntity.DeEntitize(pNode.FirstChild.InnerText) + "\n";
        }

        protected sealed override void ExtractDate()
        {
            var numberFormat = new[] { "th", "st", "nd", "rd"};
            var node = HtmlDoc.DocumentNode.SelectSingleNode(_elementsClass["Date"]);
            var dateStr = node.InnerText;
            var comma = dateStr.IndexOf(",", StringComparison.Ordinal);
            dateStr = dateStr[..comma];
            foreach(var format in numberFormat)
                if(dateStr.Contains(format))
                    dateStr = dateStr.Remove(dateStr.IndexOf(format, StringComparison.Ordinal), 2);
            Date = DateTime.Parse(dateStr);
        }

        protected sealed override void ExtractSubject()
        {
            var node = HtmlDoc.DocumentNode.SelectSingleNode(_elementsClass["Subject"]);
            Subject = node.InnerText;
        }

        protected sealed override void ExtractTitle()
        {
            Title = HtmlDoc.DocumentNode.SelectSingleNode(_elementsClass["Title"]).InnerText;
        }
        
    }
}
