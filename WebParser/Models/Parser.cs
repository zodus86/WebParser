using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebParser.Models
{
    public class Parser
    {
        public int Id { get; set; }

        public string WebHost { get; set; }

        public DateTime Date { get; set; }
        
        public string Result { get; set; }

    }
}
