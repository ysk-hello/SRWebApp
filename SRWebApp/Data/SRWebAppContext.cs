using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SRWebApp.Models;

namespace SRWebApp.Data
{
    public class SRWebAppContext : DbContext
    {
        public SRWebAppContext (DbContextOptions<SRWebAppContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=showroom;Username=postgres;Password=postgres",
                options => options.SetPostgresVersion(new Version(9, 6)));

        public DbSet<SRWebApp.Models.Team> Team { get; set; }

        public DbSet<SRWebApp.Models.Member> Member { get; set; }
    }
}
