using Microsoft.EntityFrameworkCore;
using EFTests.Entities;

namespace EFTests.DataAccess
{
    public class TestContext : DbContext
    {
        public DbSet<Entity1> Entity1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server =(localdb)\\ProjectsV13; Database=EFCore2Tests; Trusted_Connection=true;",
                    x => x.MigrationsAssembly("EFTests.Migrations"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Entity1>()
                .Property(c => c.Name)
                .HasMaxLength(100);

          
            builder.Entity<Entity2>()
                .Property(c => c.Name)
                .HasMaxLength(100);

            builder.Seed();
        }
    }
}