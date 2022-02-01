using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebParser.Models;

namespace WebParser.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Parser> Parser { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
