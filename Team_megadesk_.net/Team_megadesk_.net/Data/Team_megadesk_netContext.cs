using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team_megadesk_.net.Models;

namespace Team_megadesk_.net.Data
{
    public class Team_megadesk_netContext : DbContext
    {
        public Team_megadesk_netContext (DbContextOptions<Team_megadesk_netContext> options)
            : base(options)
        {
        }

        public DbSet<Team_megadesk_.net.Models.DeskQuote> DeskQuote { get; set; }
    }
}
