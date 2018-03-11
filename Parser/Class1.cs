using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parser {

    public class RssItem {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
    }

    public static class RssParser {
        public static IEnumerable<RssItem> GetRss() =>
            XDocument.Load("https://news.google.com/news/rss/?ned=us&gl=US&hl=en")
                .Descendants("item")
                .Select(x => new RssItem
                {
                    Title = x.Element("title").Value,
                    Description = x.Element("description").Value,
                    Date = x.Element("pubDate").Value,
                    Category = x.Element("category").Value,
                    Url = x.Element("link").Value
                });
        
    }
}
