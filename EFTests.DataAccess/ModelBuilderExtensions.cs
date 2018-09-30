using Microsoft.EntityFrameworkCore;

using EFTests.Entities;

namespace EFTests.DataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<Entity2>().HasData(
          //      new Entity2 { Id = 1, Name = "Name21Updated" },
          //     new Entity2 { Id = 2, Name = "Name22" }
          //  );

           // modelBuilder.Entity<Entity1>()              
           //     .HasData(
           //         new Entity1 { Id = 1, Name = "Name21", Entity2Id = 1},
           //         new Entity1 { Id = 2, Name = "Name22" , Entity2Id =  2}
           //   );

            
        }
    }
}