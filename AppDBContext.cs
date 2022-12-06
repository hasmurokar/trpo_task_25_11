using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace trpo_task_25_11
{
    public class AppDBContext: DbContext
    {
            private const string NameServer = "WIN-GDUP4P8GKP6";
            private const string NameDb = "task_trpo_25_11";

            public DbSet<Entrant>? Entrants { get; set; } = null!;
            public DbSet<History>? Histories { get; set; } = null!;

            public AppDBContext()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@$"Server={NameServer};Database={NameDb};Trusted_Connection=True;");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    }

