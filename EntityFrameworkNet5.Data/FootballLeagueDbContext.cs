using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using EntityFrameworkNet5.Domain;

namespace EntityFrameworkNet5.Data
{
    public class FootballLeagueDbContext: DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FootballLeague_EfCore;User Id=sa;Password=P@ssw0rd!")
                .LogTo(Console.WriteLine, new [] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information )
                .EnableSensitiveDataLogging();
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}