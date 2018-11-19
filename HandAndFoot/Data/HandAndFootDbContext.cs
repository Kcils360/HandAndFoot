using HandAndFoot.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandAndFoot.Data
{
    public class HandAndFootDbContext : DbContext
    {
        public HandAndFootDbContext(DbContextOptions<HandAndFootDbContext> options) : base(options)
        {

        }

        public DbSet<GameTable> GameTables { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
