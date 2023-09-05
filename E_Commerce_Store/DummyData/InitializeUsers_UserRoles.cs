using E_Commerce_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Store.DummyData
{
    public static class Initialize_Users_UserRoles
    {
        public static void SeedUsers_UserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
              .HasData
              (
              new UserRole()
              {
                  Id = 1,
                  Name = "user",
                  

              },
              new UserRole()
              {
                  Id = 2,
                  Name = "admin",
                  

              }
              );


            modelBuilder.Entity<User>()
                .HasData
                (
                new User()
                {
                    Id = 1,
                    UserName = "test_user",
                    Password = "test123",
                    FullName = "Test Test",
                    Email = "test@yahoo.com",
                    Address = "No 54 test road translavania",
                    UserRoleId = 1

                },
                     new User()
                     {
                         Id = 2,
                         UserName = "admin",
                         Password = "admin123",
                         FullName = "admin admin",
                         Email = "admin@mc.com",
                         Address = "Google at google",
                         UserRoleId = 2
                     }
                );
        }
    }
}
