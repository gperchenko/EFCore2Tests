using Microsoft.EntityFrameworkCore;
using EFTests.Entities;

namespace EFTests.DataAccess
{
    public class TestContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server =(localdb)\\ProjectsV13; Database=EFCore2Tests; Trusted_Connection=true;",
                    x => x.MigrationsAssembly("EFTests.Migrations"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Samurai>()
                .Property(c => c.Name)
                .HasMaxLength(100);
          
            builder.Entity<Quote>()
                .Property(c => c.Text)
                .HasMaxLength(100);
            
            builder.Entity<Battle>()
                .Property(c => c.Name)
                .HasMaxLength(100);

           builder.Seed();
        }
    }
}