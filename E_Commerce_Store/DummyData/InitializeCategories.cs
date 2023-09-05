using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.DummyData
{
    public class InitializeCategories
    {
        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
             .HasData
             (
             new Category()
             {
                 Id = 1,
                 Name = "Electronics"
             },
             new Category()
             {
                 Id = 2,
                 Name = "Fashion"
             },
             new Category()
             {
                 Id = 3,
                 Name = "Gaming"
             },
             new Category()
             {
                 Id = 4,
                 Name = "Toys"
             },
             new Category()
             {
                 Id = 5,
                 Name = "Manga"
             }
             );
        }
    }
}
