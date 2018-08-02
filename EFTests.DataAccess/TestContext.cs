using Microsoft.EntityFrameworkCore;
//using EFTests.Entities;

namespace EFTests.DataAccess
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server =(localdb)\\ProjectsV13; Database=EFCore2Tests; Trusted_Connection=true;",
                  x => x.MigrationsAssembly("EFTests.Migrations"));
        }

    }
}