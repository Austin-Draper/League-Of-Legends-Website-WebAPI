using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    public class RosterContext:DbContext
    {
        public RosterContext(DbContextOptions<RosterContext> options) : base(options)
        {

        }

        public DbSet<Roster> RosterChamps { get; set; }

    }
}
