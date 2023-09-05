using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Seeder.ProductTypes
{
    public static class Gaming
    {
        public static List<ProductDTO> GetGaming(int gamingCategoryId)
        {
            return new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Injustice 2",
                    Description = "Injustice 2 is a fighting video game developed by NetherRealm Studios. It features a roster of DC Comics characters engaging in battles with each other. Experience epic superhero showdowns and unleash powerful abilities.",
                    Price = 59.99,
                    Stock = 15,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Gaming/gaming_injustice_qanewc.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "GTA V",
                    Description = "Grand Theft Auto V is an action-adventure game developed by Rockstar North. Explore the fictional city of Los Santos, complete missions, engage in heists, and experience an open-world environment filled with criminal activities.",
                    Price = 39.99,
                    Stock = 20,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Gaming/gaming_gtav_eichqa.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cyberpunk",
                    Description = "Cyberpunk is an action role-playing game developed by CD Projekt. Set in a dystopian future, the game allows players to explore the Night City, take on missions, and make choices that shape the story. Unleash cybernetic enhancements and experience a thrilling adventure.",
                    Price = 49.99,
                    Stock = 8,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Gaming/gaming_cyberpunk_ut7ied.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cricker 22",
                    Description = "Cricker 22 is a cricket simulation game developed by EA Sports. Step into the shoes of your favorite cricket players, compete in various cricket formats, and experience the thrill of the sport.",
                    Price = 54.99,
                    Stock = 5,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Gaming/gaming_cricker22_cjjwb6.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Assassins Creed Valhalla",
                    Description = "Assassin's Creed Valhalla is an action role-playing game developed by Ubisoft. Immerse yourself in the Viking Age as Eivor, a fierce Viking warrior. Explore England, build settlements, lead raids, and uncover the mysteries of the Assassin's Brotherhood.",
                    Price = 69.99,
                    Stock = 12,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Gaming/gaming_assasins_creed_m616rr.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Batman Collection",
                    Description = "Batman Collection includes various Batman video games featuring the Dark Knight. Play as Batman, protect Gotham City, and defeat iconic villains in this action-packed collection.",
                    Price = 79.99,
                    Stock = 10,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Gaming/gaming_batman_collection_rgxw8z.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "WWE 2k 22",
                    Description = "WWE 2k 22 is a professional wrestling video game developed by Visual Concepts. Step into the squared circle, create your own wrestler, and compete in thrilling wrestling matches against WWE superstars.",
                    Price = 49.99,
                    Stock = 15,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Gaming/gaming_wwe2k22_brjsz6.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Watch Dogs Legion",
                    Description = "Watch Dogs Legion is an action-adventure game developed by Ubisoft. In a near-future London, recruit and play as anyone to build a resistance and take down an oppressive regime. Hack into the city's infrastructure, complete missions, and fight for freedom.",
                    Price = 59.99,
                    Stock = 18,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_watch-dogs-legion_atqvct.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Uncharted Collection",
                    Description = "Uncharted Collection includes the first three games in the Uncharted series: Drake's Fortune, Among Thieves, and Drake's Deception. Join Nathan Drake on his adventures, solve puzzles, and uncover ancient treasures.",
                    Price = 39.99,
                    Stock = 10,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_uncharted_nif9jm.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Spider-Man",
                    Description = "Spider-Man is an action-adventure game developed by Insomniac Games. Swing through the city as Spider-Man, fight crime, and protect New York from various villains. Experience the thrill of being the friendly neighborhood superhero.",
                    Price = 49.99,
                    Stock = 14,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_spiderman_q8ggs4.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Mortal Combat 11 Ultimate",
                    Description = "Mortal Combat 11 Ultimate is a fighting game developed by NetherRealm Studios. Choose from a roster of iconic characters and engage in brutal and intense battles. Unleash special moves, fatalities, and test your skills against other players.",
                    Price = 69.99,
                    Stock = 10,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_mortal_combat_zpgxry.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Need For Speed Heat",
                    Description = "Need for Speed Heat is a racing game developed by Ghost Games. Take part in illegal street racing, outrun the cops, and build your reputation in Palm City. Customize and drive a variety of high-performance cars in adrenaline-pumping races.",
                    Price = 44.99,
                    Stock = 8,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_nfs_heat_fdhtyh.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Read Dead Redemption 2",
                    Description = "Red Dead Redemption 2 is an action-adventure game developed by Rockstar Games. Set in the Wild West, embark on an epic journey as Arthur Morgan, a member of the Van der Linde gang. Engage in thrilling shootouts, explore vast landscapes, and experience an immersive story.",
                    Price = 59.99,
                    Stock = 12,
                    CategoryId = gamingCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601098/e_commerce/Gaming/gaming_reddeadredemption_iz8a4h.webp",
                        }
                    }
                }

            };
        }
    }
}
