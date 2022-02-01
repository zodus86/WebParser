using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParser.Data
{
    public class Html
    {
        public static string ParserWord (string url)
        {

            var htmlPage = new HtmlWeb().Load(url);
            string text = htmlPage.DocumentNode.InnerText;

            var words = text.Split(new[] { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                             .GroupBy(x => x)
                             .OrderByDescending(x => x.Count())
                             .Select(x => $"{x.Count() } - { x.Key }");
            StringBuilder sb = new StringBuilder("");
            foreach (var item in words)
            {
                sb.AppendLine(item);
            }


            return sb.ToString() ;
        }
    }
}
