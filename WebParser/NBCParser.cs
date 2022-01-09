using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace WebParser
{
    public class NBCParser : Website
    {
        private readonly Dictionary<string, string> elementsClass = new Dictionary<string, string>()
        {
            { "Date", "//time[@data-test='timestamp__datePublished']" },
            { "Content", "//div[@class='article-body__content article-body-font--loading']" },
            { "Title", "//h1[@data-test='article-hero__headline']" },
            { "Subject", "//span[@data-test='unibrow-text']" }
        };
        public NBCParser(string link) : base(link)
        {
            ExtractTitle();
            ExtractContent();
            ExtractDate();
            ExtractSubject();
        }
        protected sealed override void ExtractContent()
        {
            var node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Content"]);
            foreach (var pNode in node.SelectNodes("//p"))
                Content += HtmlEntity.DeEntitize(pNode.InnerText) + "\n";
        }

        protected override void ExtractSubject()
        {
            HtmlNode node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Subject"]);
            Subject = node.InnerText;
        }

        protected sealed override void ExtractTitle()
        {
            Title = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Title"]).InnerText.ToString();
<<<<<<< HEAD
            Console.WriteLine(Title);
=======
>>>>>>> a18f2297feb02659a9f1915ce0f2855ee6bebb99
        }
        protected sealed override void ExtractDate()
        {
            var dateStr = "DECEMBER 30, 2021 6:00 PM";
            var comma = dateStr.IndexOf(",", StringComparison.Ordinal);
            var date = dateStr.Substring(0, comma);
            string year = dateStr[(comma + 2)..].Split(' ')[0];
            date += ' ' + year;
            Date = DateTime.Parse(date);
        }
    }
}