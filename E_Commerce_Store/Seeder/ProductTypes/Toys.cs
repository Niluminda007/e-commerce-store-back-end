using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Seeder.ProductTypes
{
    public static class Toys
    {
        public static List<ProductDTO> GetToys(int toyCategoryId)
        {
            return new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cowboy Woodie",
                    Description = "Bring the Wild West to life with the Cowboy Woodie toy! This action figure features a classic cowboy design with a hat, boots, and a trusty lasso. Whether you're staging epic rodeo battles or embarking on thrilling adventures across the prairie, Cowboy Woodie will be your loyal companion. With three different poses to choose from, you can create endless imaginative play scenarios. Saddle up and let your imagination run wild with this timeless toy!",
                    Price = 12.99,
                    Stock = 3,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601111/e_commerce/Toys/toy_woodie_3_u1djvm.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Toys/toy_woodie_2_qeuyx2.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Toys/toy_woodie_1_s77niy.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Star Wars Puzzle",
                    Description = "Piece together the epic saga of Star Wars with this exciting Star Wars Puzzle! Dive into a galaxy far, far away as you assemble stunning scenes featuring your favorite characters and iconic spacecraft. With 500 pieces of intergalactic fun, this puzzle is perfect for Star Wars enthusiasts of all ages. Whether you're a Jedi Master or a Padawan learner, embrace the Force of creativity and challenge yourself to complete the puzzle. May the puzzle-solving skills be with you!",
                    Price = 9.99,
                    Stock = 5,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Toys/toy_starwars_puzzle_2_nubmaf.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Toys/toy_starwars_puzzle_br1cy0.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cinderella Doll",
                    Description = "Enter the enchanting world of Cinderella with this beautiful Cinderella Doll! Dressed in her iconic blue gown and sparkling glass slippers, Cinderella is ready to attend the royal ball. With her flowing blonde hair and a magical charm bracelet, this doll is a must-have for any Disney princess fan. Create your own fairy tale adventures and let Cinderella inspire you to follow your dreams. A perfect gift for little princesses who believe in happily ever afters!",
                    Price = 19.99,
                    Stock = 8,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Toys/toy_cinderella_1_isn1kx.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_cinderella_3_faayie.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Toys/toy_cinderella_2_jelqbl.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "PacMan Machine",
                    Description = "Relive the golden age of arcade gaming with the PacMan Machine! This nostalgic toy brings back the iconic PacMan game to your home. With its classic design and authentic sound effects, you'll feel like you're back in the arcade. Challenge yourself to gobble up all the dots and avoid the ghosts as you strive for the high score. Perfect for gamers of all ages, this PacMan Machine will provide hours of retro gaming fun!",
                    Price = 49.99,
                    Stock = 2,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_pacmanMachine_1_svdo3r.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_pacmanMachine_2_zeneok.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Toys/toy_pacmanMachine_4_zggkdt.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Toys/toy_pacmanMachine_3_gzuoi6.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Mulan Statue",
                    Description = "Celebrate the bravery and spirit of Mulan with this stunning Mulan Statue! Capturing the essence of the beloved Disney character, this statue showcases Mulan in her warrior pose, ready to defend her family and honor. With intricate details and vibrant colors, it's a true collector's item for Mulan fans. Display it proudly and let Mulan inspire you to be courageous and follow your heart. Honor your inner warrior with this remarkable Mulan Statue!",
                    Price = 29.99,
                    Stock = 6,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_mulan_2_u6nygj.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_mulan_4_bsgfth.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_mulan_3_hznfel.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Toys/toy_mulan_1_auz3lo.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Mickey Mouse",
                    Description = "Join the world's most famous mouse with this adorable Mickey Mouse toy! With his iconic red shorts, white gloves, and friendly smile, Mickey Mouse is ready to spread joy and laughter. This plush toy is perfect for cuddling and playtime adventures. Whether you're a lifelong fan of Mickey Mouse or introducing the beloved character to a new generation, this toy will bring Disney magic into your home!",
                    Price = 14.99,
                    Stock = 10,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Toys/toy_mickeymouse_2_xf7yno.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601109/e_commerce/Toys/toy_mickeymouse_3_wwuy4r.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Toys/toy_mickeymouse_1_kiimog.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "McQueen and Mater",
                    Description = "Rev up the fun with McQueen and Mater, the dynamic duo from Disney's Cars! These beloved characters come to life in this exciting toy set. McQueen, the sleek race car, and Mater, the lovable tow truck, are always ready for new adventures. With their vibrant colors and durable construction, these toys are perfect for racing playtime and imaginative storytelling. Join McQueen and Mater on the road to friendship and endless entertainment!",
                    Price = 24.99,
                    Stock = 4,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Toys/toy_cars_1_wnzieb.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Toys/toy_cars_2_xdc4gb.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Toys/toy_cars_3_o5gq3x.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Kitten Dolls",
                    Description = "Meow! Cuddle up with these adorable Kitten Dolls! This set includes four irresistibly cute kittens with different colors and patterns. Made with soft and huggable materials, these dolls are perfect companions for naptime or tea parties. Each kitten has its own unique personality, ready to be loved and cherished by little ones. Let your child's imagination roam free with these delightful Kitten Dolls!",
                    Price = 17.99,
                    Stock = 7,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_kitten_pack_1_fj0dg6.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_kitten_pack_2_h9yzxe.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Toys/toy_kitten_pack_3_csqcff.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Toys/toy_kitten_pack_4_nd6vw1.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Captain America Figure",
                    Description = "Unleash the power of justice with this Captain America Figure! Inspired by the iconic Marvel superhero, this action figure is ready to defend the world from evil. With its detailed design and articulated joints, you can pose Captain America in dynamic battle stances. Whether you're a collector or a fan of superhero adventures, this figure is a must-have addition to your collection. Join forces with Captain America and embark on thrilling missions to protect the innocent!",
                    Price = 19.99,
                    Stock = 8,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Toys/toy_captain_figure_4_xo5fiu.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Toys/toy_captain_figure_2_l1zv5j.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_captain_figure_1_il1xij.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Toys/toy_captain_figure_3_mcnsut.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "ForCar",
                    Description = "Vroom! Get ready for high-speed adventures with the ForCar! This sleek and stylish toy car is built for speed and excitement. With its aerodynamic design and vibrant color, the ForCar stands out on the race track. Zoom through corners and leave your opponents in the dust. Whether you're racing against friends or performing daring stunts, the ForCar is your ticket to thrilling automotive fun!",
                    Price = 12.99,
                    Stock = 15,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_ford_2_hmb79q.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_ford_3_ghivxx.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601105/e_commerce/Toys/toy_ford_1_psjbnu.webp",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Lego Batman and Harley",
                    Description = "Enter the world of superheroes with Lego Batman and Harley! This building set lets you create your own adventures in Gotham City. Join Batman, the Dark Knight, as he battles the mischievous Harley Quinn. Construct the iconic Batmobile and unleash its firepower against Harley's antics. With detailed Lego pieces and endless creative possibilities, this set is perfect for both Lego enthusiasts and fans of the Caped Crusader. Let your imagination soar and recreate epic battles between good and evil!",
                    Price = 29.99,
                    Stock = 10,
                    CategoryId = toyCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Toys/toy_batmanAndHarley_2_wvzwp4.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Toys/toy_batmanAndHarley_3_hiw5nq.webp",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Toys/toy_batmanAndHarley_1_j2nngn.webp",
                        }
                    }
                }


            };
        }
    }
}
