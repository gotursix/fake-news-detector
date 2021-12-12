using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParser
{
    public abstract class Website
    {
        private HtmlDocument htmlDoc;
        private String link = "";
        private DateTime date;
        private string title;
        private string content;
        private string subject;
        public string Title { get => title; protected set => title = value; }
        public DateTime Date { get => date; protected set => date = value; }
        public string Content { get => content; protected set => content = value;  }
        public string Link { get => link; protected set => link = value; }
        public string Subject { get => subject; protected set => subject = value; }
        protected HtmlDocument HtmlDoc { get => htmlDoc; private set => htmlDoc = value; }

        protected Website(string link)
        {
            Link = link;
            HtmlDoc = GetHTMLFromLink();
        }

        protected HtmlDocument GetHTMLFromLink()
        {
            HtmlWeb web = new HtmlWeb();
            return web.Load(this.Link);
        }

        protected abstract void ExtractTitle();
        protected abstract void ExtractContent();
        protected abstract void ExtractDate();
        protected abstract void ExtractSubject();
    }
}
