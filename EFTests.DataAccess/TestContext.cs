using Microsoft.EntityFrameworkCore;
using EFTests.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace EFTests.DataAccess
{
    public class TestContext : DbContext
    {
        public static readonly LoggerFactory MyConsoleLoggerFactory
            = new LoggerFactory(new []
            {
                new ConsoleLoggerProvider((category, level)
                    => category == DbLoggerCategory.Database.Command.Name
                       && level == LogLevel.Information, true) 
            });

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyConsoleLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server =(localdb)\\MSSQLLocalDB; Database=EFCore2Tests; Trusted_Connection=true;",
                    x => x.MigrationsAssembly("EFTests.Migrations"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Samurai>()
                .Property(c => c.Name)
                .HasMaxLength(100);

            builder.Entity<Samurai>()
                .Property(c => c.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
          
            builder.Entity<Quote>()
                .Property(c => c.Text)
                .HasMaxLength(100);
            
            builder.Entity<Battle>()
                .Property(c => c.Name)
                .HasMaxLength(100);

            builder.Entity<SecretIdentity>()
                .Property(c => c.RealName)
                .HasMaxLength(100);

            builder.Entity<SecretIdentity2>()
                .Property(c => c.RealName)
                .HasMaxLength(100);

            builder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.BattleId, s.SamuraiId });

            builder.Seed();
        }

        public override int SaveChanges()
        {
            //foreach (var entry in this.ChangeTracker.Entries()
            //    .Where(
            //        e => e.Entity is BMTModelBase &&
            //             (e.State == EntityState.Added) ||
            //             (e.State == EntityState.Modified)))
            //{
            //    BMTModelBase e = (BMTModelBase)entry.Entity;

            //    if (entry.State == EntityState.Added)
            //    {
            //        e.DateCreated = DateTime.Now;
            //    }

            //    e.DateUpdated = DateTime.Now;
            //}

            return base.SaveChanges();
        }
    }
}