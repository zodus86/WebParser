using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebParser.Models;

namespace WebParser.Data
{
    public class ParserRepository : IParser
    {
        private readonly DataContext dataContext;

        public ParserRepository (DataContext data)
        {
            dataContext = data;
        }

        public IEnumerable<Parser> Parsers => dataContext.Parser;

        public void Add(string url)
        {
            Parser parser = new Parser();
            parser.WebHost = url;
            parser.Date = DateTime.Now;
            parser.Result = Html.ParserWord(url);

            dataContext.Parser.Add(parser);
            dataContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var delitem = dataContext.Parser.Where(e => e.Id == Id);
            dataContext.Parser.RemoveRange(delitem);
            dataContext.SaveChangesAsync();
        }

        public Parser GetParser(int Id) => dataContext.Parser.FirstOrDefault(e => e.Id == Id);
    }
}
