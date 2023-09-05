using Microsoft.EntityFrameworkCore;
using Attribute = E_Commerce_Store.Models.Attribute;
namespace E_Commerce_Store.DummyData
{
    public static class InitializeAttributes
    {
        public static void SeedAttribute(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attribute>()
                .HasData
                (
                    new Attribute()
                    {
                        Id = 1,
                        Name = "Color"
                    },
                    new Attribute()
                    {
                        Id = 2,
                        Name = "Capacity"
                    },
                    new Attribute()
                    {
                        Id = 3,
                        Name = "Refresh Rate"
                    },
                    new Attribute()
                    {
                        Id = 4,
                        Name = "RAM"
                    }
                );
        }
    }
}
