using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    //usually a model will inherit from DbContext class... but in this case we inherit from IdentityDbContext
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options):base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<StaticChamp> StaticChamps { get; set; }//Get all champ data listed on homepage
    }
}
