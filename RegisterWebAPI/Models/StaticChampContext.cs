using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    public class StaticChampContext:DbContext
    {

        public StaticChampContext(DbContextOptions<StaticChampContext> options):base(options)
        {

        }
        
        public DbSet<StaticChamp> StaticChamps { get; set; }

    }
}
