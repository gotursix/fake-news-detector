using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebParser
{
    public class NbcParser : Website
    {
        private readonly Dictionary<string, string> elementsClass = new Dictionary<string, string>()
        {
            { "Date", "//time[@data-test='timestamp__datePublished']" },
            { "Content", "//div[@class='article-body__content article-body-font--loading']" },
            { "Title", "//h1[@data-test='article-hero__headline']" },
            { "Subject", "//span[@data-test='unibrow-text']" }
        };
        public NbcParser(string link) : base(link)
        {
            ExtractTitle();
            ExtractContent();
            ExtractDate();
            ExtractSubject();
        }
        protected sealed override void ExtractContent()
        {
            var node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Content"]);
            StringBuilder sb = new StringBuilder();
            foreach (var pNode in node.SelectNodes("//p"))
            {
                sb.Append(HtmlEntity.DeEntitize(pNode.InnerText));
                sb.Append("\n");
            }
            Content = sb.ToString();
        }

        protected override void ExtractSubject()
        {
            HtmlNode node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Subject"]);
            Subject = node.InnerText;
        }

        protected sealed override void ExtractTitle()
        {
            Title = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Title"]).InnerText.ToString();
        }
        protected sealed override void ExtractDate()
        {
            var node = HtmlDoc.DocumentNode.SelectSingleNode(elementsClass["Date"]);
            Date = DateTime.Parse(node.Attributes["content"].Value);
        }
    }
}