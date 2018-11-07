using Microsoft.EntityFrameworkCore;

using EFTests.Entities;

namespace EFTests.DataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>().HasData(
                new Samurai { Id = 1, Name = "Samu1" },
                new Samurai { Id = 2, Name = "Supper Samurai" }
            );

            modelBuilder.Entity<SecretIdentity>()              
                .HasData(
                    new SecretIdentity { Id = 1, RealName = "Dyadya Vasya", SamuraiId = 1}           
              );

            
        }
    }
}