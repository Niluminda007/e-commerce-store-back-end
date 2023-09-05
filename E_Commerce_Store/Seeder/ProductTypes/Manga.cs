using E_Commerce_Store.DTO;

namespace E_Commerce_Store.Seeder.ProductTypes
{
    public static class Manga
    {
        public static List<ProductDTO> GetManga(int mangaCategoryId)
        {
            return new List<ProductDTO>()
            {
               new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Naruto",
                    Description = "Naruto is a popular manga series written and illustrated by Masashi Kishimoto. Follow the journey of Naruto Uzumaki as he trains to become a ninja and protects his village from various threats.",
                    Price = 9.99,
                    Stock = 20,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601110/e_commerce/Manga/manga_naruto_2_rvrjws.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Manga/manga_naruto_4_pqmykt.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_naruto_3_unth2u.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601106/e_commerce/Manga/manga_naruto_1_tmr4bz.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "One Piece",
                    Description = "One Piece is a manga series written and illustrated by Eiichiro Oda. Join Monkey D. Luffy and his pirate crew as they search for the ultimate treasure, the One Piece, and navigate through the Grand Line.",
                    Price = 9.99,
                    Stock = 15,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Manga/manga_onePiece_2_frlx0b.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601108/e_commerce/Manga/manga_onePiece_1_xr9zfa.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Manga/manga_onePiece_4_dlttnc.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Manga/manga_onePiece_3_y0vrvu.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Haikyu",
                    Description = "Haikyu is a sports manga series written and illustrated by Haruichi Furudate. Follow the journey of Shoyo Hinata as he joins his high school's volleyball team and strives to become a great player.",
                    Price = 9.99,
                    Stock = 12,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Manga/manga_haikyu_1_gkpkns.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Manga/manga_haikyu_2_xzamqq.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_haikyu_4_apge0j.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_haikyu_3_k0q4pb.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Black Clover",
                    Description = "Black Clover is a fantasy manga series written and illustrated by Yuki Tabata. Join Asta and Yuno as they aim to become the Wizard King in a world where magic is everything.",
                    Price = 9.99,
                    Stock = 10,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601107/e_commerce/Manga/manga_blackClover_4_wms8ch.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_blackClover_3_fmue5i.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_blackClover_1_tl4vf5.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_blackClover_2_wog4os.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Jujutsu Kaisen",
                    Description = "Jujutsu Kaisen is a supernatural manga series written and illustrated by Gege Akutami. Follow the story of Yuji Itadori as he becomes a student at Tokyo Metropolitan Jujutsu Technical High School and fights against cursed spirits.",
                    Price = 9.99,
                    Stock = 8,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Manga/manga_jujutsu_4_vpcpmw.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601104/e_commerce/Manga/manga_jujutsu_3_eyfujd.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601103/e_commerce/Manga/manga_jujutsu_1_j4xbiq.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_jujutsu_2_rdqnfd.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hunter x Hunter",
                    Description = "Hunter x Hunter is an adventure manga series written and illustrated by Yoshihiro Togashi. Join Gon Freecss as he follows in his father's footsteps to become a Hunter and explores the world of dangerous creatures, treasures, and mysteries.",
                    Price = 9.99,
                    Stock = 7,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_hxh_4_ss6xdz.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_hxh_2_v7ybzf.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_hxh_3_ycntmp.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601102/e_commerce/Manga/manga_hxh_1_ldxzls.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Demon Slayer",
                    Description = "Demon Slayer is an action-packed manga series written and illustrated by Koyoharu Gotouge. Join Tanjiro Kamado as he becomes a Demon Slayer and seeks to avenge his family and find a cure for his sister, who has been turned into a demon.",
                    Price = 9.99,
                    Stock = 13,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_demon_slayer_4_cseue2.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_demon_slayer_3_zyfvhy.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_demon_slayer_2_vf82vf.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_demon_slayer_1_nymiht.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Death Note",
                    Description = "Death Note is a psychological thriller manga series written by Tsugumi Ohba and illustrated by Takeshi Obata. Discover the cat-and-mouse game between Light Yagami, a high school student who gains a supernatural notebook that can kill anyone whose name is written in it, and L, a brilliant detective trying to catch him.",
                    Price = 9.99,
                    Stock = 6,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_deathNote_1_adjod0.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_deathNote_2_ckit8x.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601101/e_commerce/Manga/manga_deathNote_3_qktzbm.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bleach",
                    Description = "Bleach is an action-packed manga series written and illustrated by Tite Kubo. Follow the adventures of Ichigo Kurosaki, a teenager with the ability to see ghosts, as he becomes a Soul Reaper and protects the living world from evil spirits and other supernatural threats.",
                    Price = 9.99,
                    Stock = 9,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_bleach_4_luwm0n.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_bleach_3_i65bnf.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_bleach_2_n6kwyz.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601100/e_commerce/Manga/manga_bleach_1_e8ztns.jpg",
                        }
                    }
                },
                new ProductDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = "Attack on Titan",
                    Description = "Attack on Titan, also known as Shingeki no Kyojin, is a dark fantasy manga series written and illustrated by Hajime Isayama. Set in a world where humanity is threatened by giant humanoid creatures called Titans, follow Eren Yeager and his friends as they join the fight against the Titans and uncover the mysteries of their existence.",
                    Price = 9.99,
                    Stock = 5,
                    CategoryId = mangaCategoryId,
                    ImageList = new List<ImageDTO>()
                    {
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Manga/manga_aot_1_hjw0iz.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Manga/manga_aot_4_enpvcz.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Manga/manga_aot_2_diwphr.jpg",
                        },
                        new ImageDTO()
                        {
                            Url = "https://res.cloudinary.com/dij3i3ar9/image/upload/v1686601099/e_commerce/Manga/manga_aot_3_lijvzc.jpg",
                        }
                    }
                }

            };
        }
    }
}
