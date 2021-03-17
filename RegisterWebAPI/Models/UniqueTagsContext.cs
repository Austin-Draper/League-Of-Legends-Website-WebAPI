using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    public class UniqueTagsContext:DbContext
    {
        public UniqueTagsContext(DbContextOptions<UniqueTagsContext> options) : base(options)
        {

        }

        public DbSet<UniqueTags> UniqueTags { get; set; }
    }
}
