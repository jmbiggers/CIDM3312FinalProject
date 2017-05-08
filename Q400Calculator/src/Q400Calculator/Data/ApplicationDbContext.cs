using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Models;
using Q400Calculator.Interfaces;

namespace Q400Calculator.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClimbData> ClimbData { get; set; }
        public DbSet<TakeOffData> TakeOffData { get; set; }
        public DbSet<LandingData> LandingData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ClimbData>().ToTable("ClimbData");
            builder.Entity<TakeOffData>().ToTable("TakeOffData");
            builder.Entity<LandingData>().ToTable("LandingData");

        }
    }
}
