using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebParser.Models;

namespace WebParser.Data
{
    public interface IParser
    {
        IEnumerable<Parser> Parsers { get; }

        Parser GetParser(int Id);

        void Add(string url);

        void Delete(int Id);

        
    }
}
